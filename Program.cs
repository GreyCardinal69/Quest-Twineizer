using System;
using System.IO;
using System.Text;
using EditorDatabase.Serializable;
using Newtonsoft.Json;

namespace Quest_Twine_Izer
{
    class Program
    {
        private static string _directory = Directory.GetCurrentDirectory();
        private static string _firstHalf = File.ReadAllText(@$"{_directory}\FirstHalf.txt");
        private static string _secondHalf = File.ReadAllText( @$"{_directory}\SecondHalf.txt" );

        private static int _yLevel = 250;
        private static int _xLevel = 40;

        static void Main ( string[] args )
        {
            var quest = JsonConvert.DeserializeObject<QuestSerializable>(File.ReadAllText(args[0]));

            StringBuilder result = new StringBuilder();

            int totalNodesInLine = 0;
            int floorLimit = 0;

            var len = quest.Nodes.Length;

            if (len < 40)
            {
                floorLimit = 15;
            }
            else if (len > 40 && len < 70)
            {
                floorLimit = 25;
            }
            else
            {
                floorLimit = 35;
            }

            result.Append(_firstHalf);

            int count = 0;

            foreach (var node in quest.Nodes)
            {
                result.Append
                    (
                    $"<tw-passagedata pid=\"{node.Id}\" name=\"{node.Id}\" tags=\"\" position=\"{_xLevel}, " +
                    $"{Math.Clamp((count > 0 ? _yLevel + new System.Random().Next(-300,300) : _yLevel + new System.Random().Next(-150,250)), 0, 1000000)}" +
                    $"\" size=\"100, 100\">"
                    );

                result.Append('{');
                result.Append( JsonConvert.SerializeObject( node, Formatting.Indented, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore } ) );

                if (node.Actions != null)
                {
                    if (node.Actions.Length > 1)
                    {
                        count += node.Actions.Length;
                    }
                    result.Append( '\n' );
                    result.Append( '/' );
                    foreach (var item in node.Actions)
                    {
                        result.Append( $"[[{item.ButtonText}|{item.TargetNode}]]" );
                    }
                }

                if (node.Actions == null && node.Transitions != null)
                {
                    if (node.Transitions.Length > 1)
                    {
                        count += node.Transitions.Length;
                    }
                    result.Append( '\n' );
                    result.Append( '/' );
                    foreach (var item in node.Transitions)
                    {
                        result.Append( $"[[{item.TargetNode}|{item.TargetNode}]]" );
                    }
                }

                if (node.Transitions == null && node.Actions == null)
                {
                    result.Append( '\n' );
                    result.Append( '/' );
                    result.Append( $"[[{node.DefaultTransition}|{node.DefaultTransition}]]" );
                }

                result.Append( "</tw-passagedata>" );

                _xLevel += 150;

                totalNodesInLine++;

                if (totalNodesInLine >= floorLimit)
                {
                    _yLevel += 580;
                    _xLevel = 10;
                    totalNodesInLine = 0;
                }

                if (count > 0)
                {
                    count--;
                }
            }

            result.Append( _secondHalf );

            File.WriteAllText($"{_directory}\\YourQuest.html", result.ToString());
        }
    }
}