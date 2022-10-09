# Quest-Twineizer
Used for the conversion of Event Horizon Quest files into Twine stories.

Usage:
- Drag and drop your quest into QuestTwineizer.exe
- Import the output YourQuest.html file in Twine
  - When in the Twine main page select "Import From File" then select the generated YourQuest.html file.
  
The generated Twine story will look like the one below. Each story layout is generated in a different way, every time.

![Screenshot 2022-10-10 015746](https://user-images.githubusercontent.com/50517794/194781417-6409be32-027e-4aed-9a71-72a6935e9ddd.jpg)

<h1>Exporting Story As Quest</h1>

For this you will need the attached Twison zip.

When exporting you need to copy the exported content of the quest's Nodes [].
Quest data like id, name and so on is not saved when importing quest into story.

To use Twison you will need NodeJS.
- In the Twison folder Right click inside the folder and choose "Git Bash Here"
- In the console type "node server.js"
- Inside Twine, on the main page choose "Formats"
- Inside the formats menu choose "Twison 0.0.1"
- Go into your story
- Click on the story name
- Click "Change Story Format" and choose "Twison 0.0.1"
- Click Play, if your story contains no errors the quest json will be opened in your default browser.

-------------------------------------------------------------

<h1>Editing The Story</h1>

The generated story nodes look like this:
```json
{{
  "Id": 1,
  "Type": 20,
  "Message": null,
  "DefaultTransition": 4,
  "FailureTransition": 2,
  "Enemy": 123070
}
[[4|4]][[5|5]]
```

The first line has an extra "{", dont touch it.

The last line is used to show transitions in the story, the format is as follows:

[[ text | transition_id ]]
All transitions must be on the same line.

----------------------------------------------------------

<h2> Verbose </h2>

In the example above, the story node has verbose json in it, it is not necessary to do so. For example:
```json
{{
  "Id": 1,
  "Type": 10,
  "Message": "I am receiving a transmission from the space station.",
  "Character": 7814
}
[[Continue.|22]]
```
```json
{"Character":12}
I am watching you.
[[Continue.|22]]
```

Are both valid story nodes.
Not all the json must be written, the above will be exported as valid dialog node, with only ac


