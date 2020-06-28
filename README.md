# Animation
Animation controllers, Animations and Scripts relating to animation.

I am not an animator. The animations in here are not, at least right now, very good. However, this is a useful library for use in other 
open source projects that need animations and controllers in demo scenes. While not pretty it does enable open source projects to work
out of the box. Help us make this package truly useful by contributing.

If you know of a source of decent open source animations let us.

# Installation

  1. `Window -> Package Manager`
  2. Click the '+" in the top left
  3. Select 'Add package from Git URL'
  4. Paste in 'https://github.com/TheWizardsCode/Animation.git#release/stable'

# Release Process

We use [PackageTools](https://github.com/3dtbd/unity-package-tools) to create our releases. To build a release:

  0. Alongside your working repository checkout the `release/stable` branch of this repo
  1. Update (at least) the version number in the `PackageManifestConfig` in the root of the `Assets` folder
  2. Click `Generate VersionConstants.cs` in the inspector
  3. Commit the new constants file to Git
  4. Click `Export Package Source`
  5. Commit and push the changes in your release project to GitHub
