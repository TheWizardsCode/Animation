This repository has been merged with https://github.com/TheWizardsCode/Character please use that repo instead.
















Original README

# Animation
Animation controllers, Animations and Scripts relating to Unity animations.

I am not an animator. The animations in here are not, at least right now, very good. However, this is a useful library for use in other 
open source projects that need animations and controllers in demo scenes. While not pretty it does enable open source projects to work
out of the box. Help us make this package truly useful by contributing.

If you know of a source of decent open source animations let us.

What we have so far:

  * Humanoid Animation Controller with layers for movement and talking
  * NavMesh movement to Animation Controller parameters MonoBehaviour
  * Support scripts or semi-procedural body/arms animation for a talking character (does not provide Lip Sync we recommend [Salsa](http://bit.ly/UnitySalsa) for that)
  * Wander script

# Installation

## Unity 2019

  1. `Window -> Package Manager`
  2. Click the '+" in the top left
  3. Select 'Add package from Git URL'
  4. Paste in `https://github.com/TheWizardsCode/Animation.git#release/stable`

## Unity 2018

  You need to manualy add the above URL to the package mananifest.

# Documentation

This is an open source project, don't expect stellar documentation, but do help us improve what we have in the [Documentation](Assets/Documentation) folder.

To make this easier we use a Unity [Markdown Plugin](https://github.com/gwaredd/UnityMarkdownViewer) that allows you to view the documentation from within Unity. 
You can create a new markdown document from the assets create menu Assets -> Create -> Markdown.

# Development

We welcome your contributons to this project. This repository is a complete Unity project, check it out and have at it. Note, this repository is not intended for import into your projects, see the Installation section above for that use case.

# Release Process

We use [PackageTools](https://github.com/jeffcampbellmakesgames/unity-package-tools) to create our releases. To build a release:

  0. Alongside your working repository checkout the `release/stable` branch of this repo into a directory called `Animation-Release` using `git clone --single-branch --branch release/stable git@github.com:TheWizardsCode/Animation.git Animation-Release`
  1. Update the version number in the `Release Candidate PackageManifestConfig` to match that in `DevTest PackageManifestConfig` (both are in the root of the `Assets` folder)
  2. Increase the version number in the `DevTest PackageManifestConfig` to represent the next release number (not this release)
  3. Click `Generate VersionConstants.cs` in the inspector from the `Release Candidate PackageManifestConfig` inspector
  4. Commit the new constants file to Git
  5. Click `Export Package Source` in the inspector for the `Release Candidate PackageManifestConfig`
  6. Commit and push the changes in `DevLogger-Release` to GitHub [SEE BELOW for a known issue]

NOTE there is currently a [bug](https://github.com/jeffcampbellmakesgames/unity-package-tools/issues/11) in the package manager tool that prevents the above from working, at least on my machine. You can work around the bug with the following steps:

1. Delete the existing package directory
2. Export the package source
3. cd into the package directory
4. `git init`
5. `git remote add origin git@github.com:TheWizardsCode/Animation.git`
6. `git fetch`
7. `git add .`
8. `git commit -m "Release v0.2.5`
9. `git branch -m master release/stable`
10. `git push -f -u origin release/stable`
