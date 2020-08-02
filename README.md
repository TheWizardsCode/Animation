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
  4. Paste in `https://github.com/TheWizardsCode/Animation.git#release/stable`

# Documentation

This is an open source project, don't expect stellar documentation, but do help us improve what we have in the [Documentation](Assets/Documentation) folder.

To make this easier we use a Unity [Markdown Plugin](https://github.com/gwaredd/UnityMarkdownViewer) that allows you to view the documentation from within Unity. 
You can create a new markdown document from the assets create menu Assets -> Create -> Markdown.

# Development

We welcome your contributons to this project. This repository is a complete Unity project, check it out and have at it. Note, this repository is not intended for import into your projects, see the Installation section above for that use case.

# Release Process

We use [PackageTools](https://github.com/3dtbd/unity-package-tools) to create our releases. To build a release:

  0. Alongside your working repository checkout the `release/stable` branch of this repo
  1. Update (at least) the version number in the `PackageManifestConfig` in the root of the `Assets` folder
  2. Click `Generate VersionConstants.cs` in the inspector
  3. Commit the new constants file to Git
  4. Click `Export Package Source`
  5. Commit and push the changes in your release project to GitHub
