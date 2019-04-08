Sprite Sheet Creator
(c) 2016 Digital Ruby, LLC
Created by Jeff Johnson
https://www.digitalruby.com/unity-plugins/

Version 1.0.3

Setup
--------------------
There are two ways to use sprite sheet creator.

Animator: Open scene SpriteSheetCreatorSceneAnimator.
When you press play and then click export, the Animator will play through each frame of whatever the default animation is set to for the Animator. This becomes your sprite sheet. The example animator uses a 3D model of a fish.

Other Objects (i.e. Particle System): Open scene SpriteSheetCreatorSceneGameObject.
Set the AnimationDuration property to a value that will allow you to capture a nice set of motions. Run the scene and click export and the animation captures over the duration to give you a wide variety of frames. The example in the asset is a fire particle system.

Preview
--------------------
The default save file is SpriteSheetCreator/SpriteSheet.png. Once the export is done, you will get a preview of your sprite sheet right in play mode. You can see how it looked. If something isn't right, it's super fast to change some parameters and click export again. No need to open the sprite sheet in other editors or programs.

Parameters (these are on a script on the SpriteSheetCreator in the scenes)
--------------------
- Info: Read-only field that contains the dimensions of the output image, calculated from the width and height of your frame size as well as the row and column count
- Frame Width: Pixel width of each frame
- Frame Height: Pixel height of each frame
- Rows: Total rows in the whole sprite sheet
- Columns: Total columns in the whole sprite sheet
- Background Color: Background color of the sprite sheet. Default is transparent. For particle systems that are additive, you'll want to change this to black.
- Animator: The animator to use for the animation. Set to null if you are not using the Animator.
- Animation Duration (seconds): Can be used instead of Animator if you are capturing something like a particle system.
- Export Root: The game object and hierarchy being turned into a sprite sheet.
- Save File Name: Leave blank generally, which will cause the export to go into SpriteSheet.png, and will allow rapid preview of your results.
- Export Complete Label: A label that tells you when the export is done.
- Preview Particle System: A particle system set up to use texture sheeet animation and allow rapid preview of your export results.
- Preview FPS: Frames per second for the preview particle system.
- Aspect Ratio Overlay: Controls the square that tells you what part of your scene is being captured.
- Camera: The camera being used for the sprite sheet capture.

Work Flow
--------------------
Set up the parameters how you want, get the object(s) in your scene that will be captured and press play. Everything should be inside the square that you want to capture. When you are ready, click 'export'. Your sprite sheet will be saved an begin previewing immediately.

Special Considerations
--------------------
If you are using a transparent background, any particle systems need to use one of the following shaders: "Particles/Sprite Sheet Creator Additive" or "Particles/Sprite Sheet Creator Alpha Blended".

In your scene view, a border appears to show you what part of the scene will be exported for each frame.

Credits
--------------------
http://opengameart.org/content/fish-animated

About Me
--------------------
I'm Jeff Johnson, Creator of Sprite Sheet Creator. Please send questions, feedback or bug reports to support@digitalruby.com
