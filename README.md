# Animation

This project contains scripts and animation controllers for Unity. However, it doesn't contain many decent animations. These are just hard to come by under an open license.

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
5. `git remote add origin git@...`
6. `git fetch`
7. `git add .`
8. `git commit -m "Release v0.2.5`
9. `git branch -m master release/stable`
10. `git push -f -u origin release/stable`