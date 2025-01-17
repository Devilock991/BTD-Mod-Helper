- @GrahamKracker has started an `AdvancedBloonsTD6Mod` class that has pre/post versions and ref parameters for hooks
- .wav files in your project will now be automatically included as embedded resources and loaded into AudioClips
  - To directly get and play a custom sound "MySound.wav" `AudioClip`, you'd do `ModContent.GetAudioClip<YourBloonsTD6Mod>("MySound").Play()`
  - To use the custom sound in a `SoundModel` you'd do `soundModel.assetId = ModContent.GetAudioSourceReference<YourBloonsTD6Mod>("MySound")`
- Fixed FileIOHelper.LoadObject<T>
- Updated VanillaSprites with v35 textures
- Fixed Open Local Files Directory button
- Re enabled Monkey Knowledge getting exported from the Game Model
- Game Model Export also will create a `resources.json` file listing the GUID / resource mappings
- Added `LateApplyUpgrade` and `EarlyApplyUpgrade` methods to simplify having some parts of upgrade effects apply after/before all others