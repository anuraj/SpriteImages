# SpriteImages
An image sprite is a collection of images put into a single image. A web page with many images can take a long time to load and generates multiple server requests. Using image sprites will reduce the number of server requests and save bandwidth.
This utility will help to create sprite image and related CSS file.

## How to use SpriteImages
It is console application, which takes source image directory as the input, and create sprite image and CSS file to the target directory provided. If no target directory provided, it will take the application executing path and creates an output folder and generates the files. 

`C:\spriteimages.exe --source C:\Sample` - Generates sprite image and CSS files under C:\Output folder.

`C:\spriteimages.exe --source C:\Sample --target C:\Sample\Sprite` - Generates sprite image and CSS files under C:\Sample\Sprite folder.

`C:\spriteimages.exe --source C:\Sample --target C:\Sample\Sprite --useClass` - Generates sprite image and CSS files under C:\Sample\Sprite folder. The generated CSS element names will be with "." otherwise it will be with "#"
