## [40.4.2](https://github.com/christides11/hack-and-slash-framework/compare/v40.4.1...v40.4.2) (2024-04-17)


### Bug Fixes

* Fixed DataEditor Inspector Updating ([be6b095](https://github.com/christides11/hack-and-slash-framework/commit/be6b095e240cab605fb8105cfd4c894f926e36a2))

## [40.4.1](https://github.com/christides11/hack-and-slash-framework/compare/v40.4.0...v40.4.1) (2024-03-07)


### Bug Fixes

* Removed CheckForInputSequence ([63c3257](https://github.com/christides11/hack-and-slash-framework/commit/63c325760c8458a8a6c728f1cb7d87d8b88b228e))

# [40.4.0](https://github.com/christides11/hack-and-slash-framework/compare/v40.3.0...v40.4.0) (2024-03-03)


### Features

* Base State processing order ([a258f41](https://github.com/christides11/hack-and-slash-framework/commit/a258f41a9aabb12e5aae0a6b795009e7d44ddec0))

# [40.3.0](https://github.com/christides11/hack-and-slash-framework/compare/v40.2.2...v40.3.0) (2024-01-16)


### Features

* Default value support for IStateVariables ([eb07814](https://github.com/christides11/hack-and-slash-framework/commit/eb07814abb52a09c30060b07d0fc70cc096d48c9))

## [40.2.2](https://github.com/christides11/hack-and-slash-framework/compare/v40.2.1...v40.2.2) (2023-11-23)


### Bug Fixes

* Property Drawer include children ([42c611e](https://github.com/christides11/hack-and-slash-framework/commit/42c611e285e55ba996d830498c84897ed2ad84ec))

## [40.2.1](https://github.com/christides11/hack-and-slash-framework/compare/v40.2.0...v40.2.1) (2023-11-14)


### Bug Fixes

* Fixed StateTimeline frame range copy/paste ([ca20632](https://github.com/christides11/hack-and-slash-framework/commit/ca2063259c2152e0d54c4ff074af4ad741688f77))

# [40.2.0](https://github.com/christides11/hack-and-slash-framework/compare/v40.1.0...v40.2.0) (2023-11-11)


### Features

* InputBitmask hold time var. ([4b2d8bc](https://github.com/christides11/hack-and-slash-framework/commit/4b2d8bc43ebf23a3fb23a6ae7b6ad447790f10bc))

# [40.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v40.0.0...v40.1.0) (2023-11-11)


### Features

* Start of new input reading system. ([4433e49](https://github.com/christides11/hack-and-slash-framework/commit/4433e49279a17385e546bf8b5a5acda275d62346))

# [40.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.13.0...v40.0.0) (2023-10-01)


### Code Refactoring

* Context for state functions & conditions ([0a4c956](https://github.com/christides11/hack-and-slash-framework/commit/0a4c95665780c90a214c0128bb634d3c78c8eeb0))


### BREAKING CHANGES

* Now pass context objects into state functions/conditions.
Makes it easier to change what we pass into them later on.

# [39.13.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.12.0...v39.13.0) (2023-09-30)


### Features

* Added typing for state variables. ([9bf5896](https://github.com/christides11/hack-and-slash-framework/commit/9bf58967f23829d59ab23b925f29842846b21663))

# [39.12.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.11.0...v39.12.0) (2023-07-20)


### Features

* Updated to 2022.3.5f1 ([ee61646](https://github.com/christides11/hack-and-slash-framework/commit/ee6164666229a68d0db2ae5dab4681f6af26ebdc))

# [39.11.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.10.0...v39.11.0) (2023-07-19)


### Features

* Removed FunctionMap from ConditionVariables ([e23fc18](https://github.com/christides11/hack-and-slash-framework/commit/e23fc1856f032c9261771ac9f5eff40bcb95f86a))


### BREAKING CHANGES

* FunctionMap is unnecessary.

# [39.10.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.9.2...v39.10.0) (2023-07-19)


### Features

* StateTimeline inspector using UI Toolkit ([89c78a1](https://github.com/christides11/hack-and-slash-framework/commit/89c78a18c5aab7c4cf7a635e0c3b24ebd2e7b0da))

## [39.9.2](https://github.com/christides11/hack-and-slash-framework/compare/v39.9.1...v39.9.2) (2023-03-13)


### Bug Fixes

* Fixed state ID map null issue. ([b28a9cd](https://github.com/christides11/hack-and-slash-framework/commit/b28a9cdc2875dfbe1c344fda88216cc3cc0cb1b6))

## [39.9.1](https://github.com/christides11/hack-and-slash-framework/compare/v39.9.0...v39.9.1) (2023-03-05)


### Bug Fixes

* CI fix. ([f522be7](https://github.com/christides11/hack-and-slash-framework/commit/f522be78f381a6f3b5367a986adc51df470edced))

# [39.9.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.8.1...v39.9.0) (2023-03-05)


### Features

* Evaluating state during hitstop support ([9404c10](https://github.com/christides11/hack-and-slash-framework/commit/9404c10872e0335fc6a666b994ddb64e4c83cea7))


### BREAKING CHANGES

* Added RunDuringHitstop to IStateVariable.

## [39.8.1](https://github.com/christides11/hack-and-slash-framework/compare/v39.8.0...v39.8.1) (2023-03-04)


### Bug Fixes

* Fixed IStateVariable pasting with no parent ([ed8b6fa](https://github.com/christides11/hack-and-slash-framework/commit/ed8b6fae6602d77e446c85b38c485175dd492683))

# [39.8.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.7.4...v39.8.0) (2023-02-28)


### Features

* State Reference copying. ([732e9cc](https://github.com/christides11/hack-and-slash-framework/commit/732e9cc89bd0da726fdc44958ef423e48b8a33d8))

## [39.7.4](https://github.com/christides11/hack-and-slash-framework/compare/v39.7.3...v39.7.4) (2023-02-28)


### Bug Fixes

* Fixed StateTimeline pasting as child ([4add6cd](https://github.com/christides11/hack-and-slash-framework/commit/4add6cd0e492d0ffbcae32283360889b1aa91014))

## [39.7.3](https://github.com/christides11/hack-and-slash-framework/compare/v39.7.2...v39.7.3) (2023-02-27)


### Bug Fixes

* Fixed copying IStateVariable condition ([602bee8](https://github.com/christides11/hack-and-slash-framework/commit/602bee850813cd29c46c4db2e4f85b652c669b62))

## [39.7.2](https://github.com/christides11/hack-and-slash-framework/compare/v39.7.1...v39.7.2) (2023-02-27)


### Bug Fixes

* Fixed IStateVariable copy/paste bugs ([ff85c9a](https://github.com/christides11/hack-and-slash-framework/commit/ff85c9a8733b816a3bee060878a4c71f1693ec3c))

## [39.7.1](https://github.com/christides11/hack-and-slash-framework/compare/v39.7.0...v39.7.1) (2023-02-27)


### Bug Fixes

* IStateVariable Copy FrameRanges ([30c4099](https://github.com/christides11/hack-and-slash-framework/commit/30c40996a13c2bff41fde6a169c25f4b2e1fc719))

# [39.7.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.6.0...v39.7.0) (2023-02-27)


### Features

* Copy/Pasting IStateVariables ([7812abc](https://github.com/christides11/hack-and-slash-framework/commit/7812abcbd8d46b227af2f4c4ddb0dd8181f903e1))


### BREAKING CHANGES

* IStateVariables & IConditionVariables have copy methods.

# [39.6.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.5.0...v39.6.0) (2023-02-23)


### Features

* State frame range % for functions ([ffd4229](https://github.com/christides11/hack-and-slash-framework/commit/ffd4229e88dfae1b47019cc9d976990d3d04bff6))


### BREAKING CHANGES

* Added frame range percentage for functions.

# [39.5.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.4.1...v39.5.0) (2022-11-24)


### Features

* Force parameter for MarkForStateChange ([e386a8f](https://github.com/christides11/hack-and-slash-framework/commit/e386a8fa3a13f8898134fd6c0ec7f9a6ee66aa65))

## [39.4.1](https://github.com/christides11/hack-and-slash-framework/compare/v39.4.0...v39.4.1) (2022-11-13)


### Bug Fixes

* Fixed contexual menu freezing ([8dc65fa](https://github.com/christides11/hack-and-slash-framework/commit/8dc65fa6698e80753f83cc4e3606ac7e77156081))

# [39.4.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.3.0...v39.4.0) (2022-11-07)

# [39.3.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.2.4...v39.3.0) (2022-09-13)


### Features

* MarkForStateChange frame var ([ff279f1](https://github.com/christides11/hack-and-slash-framework/commit/ff279f14ad1b8f3cb3268f57d7ad42017c864691))

## [39.2.4](https://github.com/christides11/hack-and-slash-framework/compare/v39.2.3...v39.2.4) (2022-08-20)


### Bug Fixes

* Fixed error with UnityEditor namespace ([5129d91](https://github.com/christides11/hack-and-slash-framework/commit/5129d9117ec510e47d5115a3f8eceedc780d9552))

## [39.2.3](https://github.com/christides11/hack-and-slash-framework/compare/v39.2.2...v39.2.3) (2022-08-04)


### Bug Fixes

* Error with no parent state vars ([dc44828](https://github.com/christides11/hack-and-slash-framework/commit/dc44828f002a71db48aa606a60e9d8e65a4173e6))

## [39.2.2](https://github.com/christides11/hack-and-slash-framework/compare/v39.2.1...v39.2.2) (2022-08-04)


### Bug Fixes

* Fixed removing state var child error ([b09c76e](https://github.com/christides11/hack-and-slash-framework/commit/b09c76e72d228ca3da603d7d90460dc99aae97e9))

## [39.2.1](https://github.com/christides11/hack-and-slash-framework/compare/v39.2.0...v39.2.1) (2022-08-02)


### Bug Fixes

* Updated semantic-release-action ([7c55b34](https://github.com/christides11/hack-and-slash-framework/commit/7c55b3467a07ed3ebedf024c7dbc4dc88f22d309))

# [39.2.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.1.1...v39.2.0) (2022-08-02)


### Features

* Test ([5f25b8b](https://github.com/christides11/hack-and-slash-framework/commit/5f25b8bf5df928f7f2bccf5d3aa9fdb4a11e6c80))

## [39.1.1](https://github.com/christides11/hack-and-slash-framework/compare/v39.1.0...v39.1.1) (2022-08-02)


### Bug Fixes

* Build IDMaps for base states. ([575084e](https://github.com/christides11/hack-and-slash-framework/commit/575084ecf5874eed79a8e560c10b172a55009233))

# [39.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v39.0.0...v39.1.0) (2022-07-24)


### Features

* Name for IntStateMap ([730e8bd](https://github.com/christides11/hack-and-slash-framework/commit/730e8bdaabb1b98ad4cbb98cbfa5a1cda97a1f6d))

# [39.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v38.2.0...v39.0.0) (2022-07-21)


### Code Refactoring

* Changed FrameRange to Vector2Int ([e7d64dc](https://github.com/christides11/hack-and-slash-framework/commit/e7d64dc5ee7abcfd731aef68fe9cea7f9b966cef))


### BREAKING CHANGES

* FrameRange for StateTimelineVariables are now Vector2Ints instead of Vector2.

# [38.2.0](https://github.com/christides11/hack-and-slash-framework/compare/v38.1.3...v38.2.0) (2022-07-21)


### Features

* Changed negative number frame meanings ([3eaf910](https://github.com/christides11/hack-and-slash-framework/commit/3eaf910eb239ed42ea496ee3d1329a0030d118bf))


### BREAKING CHANGES

* For state frame ranges, -1 now means the last frame, -2 means the onchange frame.

## [38.1.3](https://github.com/christides11/hack-and-slash-framework/compare/v38.1.2...v38.1.3) (2022-07-21)


### Bug Fixes

* ID error when last state var was moved ([0c36d3b](https://github.com/christides11/hack-and-slash-framework/commit/0c36d3b7e826eee41863af29ba23e48599a8802c))

## [38.1.2](https://github.com/christides11/hack-and-slash-framework/compare/v38.1.1...v38.1.2) (2022-07-18)


### Bug Fixes

* Fixed StateTimelineDataEditor children issue ([3ff83a0](https://github.com/christides11/hack-and-slash-framework/commit/3ff83a0a1ff80f9655694b6e5fdc547aaf289537))

## [38.1.1](https://github.com/christides11/hack-and-slash-framework/compare/v38.1.0...v38.1.1) (2022-07-18)


### Bug Fixes

* Better framebar drawing. ([7968eb4](https://github.com/christides11/hack-and-slash-framework/commit/7968eb4471f3da300466a65c2ffa182cb641f0f7))

# [38.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v38.0.1...v38.1.0) (2022-07-18)


### Features

* Move StateTimeline vars up/down. ([f8058b7](https://github.com/christides11/hack-and-slash-framework/commit/f8058b7daa8baeb55b56d041890997d3b4b52349))
* StateTimelineEditor show parent timelines. ([47d3c08](https://github.com/christides11/hack-and-slash-framework/commit/47d3c0874fbe9b94bf0ccc7688e280b4a8c48458))

## [38.0.1](https://github.com/christides11/hack-and-slash-framework/compare/v38.0.0...v38.0.1) (2022-07-16)


### Bug Fixes

* Fixed StateTimelineDataEditor ([30e8970](https://github.com/christides11/hack-and-slash-framework/commit/30e8970aa13b82663d168f12cb42c9fcf49f8480))

# [38.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v37.1.0...v38.0.0) (2022-07-16)


### Code Refactoring

* Removed FunctionMap ([4a206fe](https://github.com/christides11/hack-and-slash-framework/commit/4a206fe13372846e4da22bfed3ef1ec6455a40b2))


### BREAKING CHANGES

* Removed FunctionMap variable from IStateVariables.

# [37.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v37.0.0...v37.1.0) (2022-07-11)


### Features

* Refreshing of State Editor ([7b92e11](https://github.com/christides11/hack-and-slash-framework/commit/7b92e1116dd25c573c7b654861b94b390791d507))
* Virtual members ([d6d983e](https://github.com/christides11/hack-and-slash-framework/commit/d6d983e3930fc1287e8c75d214692067a4a19dcd))

# [37.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v36.1.1...v37.0.0) (2022-07-09)


### Code Refactoring

* flattened statetimeline variable list ([4e30a30](https://github.com/christides11/hack-and-slash-framework/commit/4e30a305522b105bdd977c348a457ab1407991db))


### Features

* add & remove state vars from timeline editor ([e3b2f24](https://github.com/christides11/hack-and-slash-framework/commit/e3b2f24ae8ef7c618d5c038ca497bf0cdcbdb007))
* Alternating bg color for State Editor window ([52714d3](https://github.com/christides11/hack-and-slash-framework/commit/52714d36147a1d1c90b296b502ba69fd0e174f1f))
* Context menu for Timeline Editor vars. ([81b3fae](https://github.com/christides11/hack-and-slash-framework/commit/81b3fae57f4ae280eec3cdc9edfa161f068930cf))
* State Timeline editor window. ([a687eea](https://github.com/christides11/hack-and-slash-framework/commit/a687eea8e01cffcf7473dcc27eb61747d63977e2))
* zoom for state timeline editor ([ca88619](https://github.com/christides11/hack-and-slash-framework/commit/ca88619bbfaf94c32ea9383061f06e08c408475d))


### BREAKING CHANGES

* Various changes to StateTimeline to make the editor window work.
* IStateVariables now refer to their children by ID.

## [36.1.1](https://github.com/christides11/hack-and-slash-framework/compare/v36.1.0...v36.1.1) (2022-05-30)


### Bug Fixes

* Fixed compile error due to editor scripts. ([1ffa1d8](https://github.com/christides11/hack-and-slash-framework/commit/1ffa1d824e86e5bfdf06d17a40a36ed0dc515405))

# [36.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v36.0.0...v36.1.0) (2022-05-23)


### Features

* StateTimeline auto loop frame variable. ([752ab40](https://github.com/christides11/hack-and-slash-framework/commit/752ab407e5341bdb62034b9a06ca39235d64426e))
* StateTimeline stateName variable. ([d8caafe](https://github.com/christides11/hack-and-slash-framework/commit/d8caafe1eb3023fec84df608005784fea65a7c7e))

# [36.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v35.1.0...v36.0.0) (2022-05-21)


### Code Refactoring

* Added more context for state functions ([9c99b77](https://github.com/christides11/hack-and-slash-framework/commit/9c99b773b34802598da962ffa37d3bb336dc9d88))
* Changed function ID to Type. ([789111c](https://github.com/christides11/hack-and-slash-framework/commit/789111c52187eeec63ab16c37099ed8936f3ee78))


### BREAKING CHANGES

* Changed the function signature of state functions to include the state being handled and the frame it's on.
* Changed function ID from int to type.

# [35.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v35.0.0...v35.1.0) (2022-04-27)


### Features

* Added StateTimeline editor. ([78b5362](https://github.com/christides11/hack-and-slash-framework/commit/78b5362ef7f5e407c9af9c724afad7d0b547f25c))
* IStateVariable children. ([839baac](https://github.com/christides11/hack-and-slash-framework/commit/839baac930e2196f9cab392f8e92c105c8fdb814))

# [35.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v34.0.0...v35.0.0) (2022-04-25)


### Code Refactoring

* Better moveset state change handling ([1904fad](https://github.com/christides11/hack-and-slash-framework/commit/1904fadf309f5a7d8bffd4a9682f85c553dc2b19))


### BREAKING CHANGES

* Settings moveset is optional for changing state.

# [34.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v33.0.0...v34.0.0) (2022-04-25)


### Bug Fixes

* Removed timeline assembly reference ([d034a07](https://github.com/christides11/hack-and-slash-framework/commit/d034a07496fd1ee9cd3dae34f86a50cf241869a4))


### Features

* Added function MarkForStateChange. ([d69ac71](https://github.com/christides11/hack-and-slash-framework/commit/d69ac71ff2651398ba4ee72f6ff63a43b84f422d))
* Added IStateVariables to StateTimeline. ([2e7316a](https://github.com/christides11/hack-and-slash-framework/commit/2e7316a5416f138243e03bb44a5afb1a47cb8860))
* Added state & condition variables ([95e3c9b](https://github.com/christides11/hack-and-slash-framework/commit/95e3c9bca3aab6dcc46a220dc6cc47164d1d08c3))
* Added useBaseState to StateTimeline ([244add5](https://github.com/christides11/hack-and-slash-framework/commit/244add5faaf1c21a707b18db487d59df9c28d241))
* IncrementFrame amount parameter. ([615b961](https://github.com/christides11/hack-and-slash-framework/commit/615b961d2e916deabba11ea945fde762df2e0c1e))
* MarkForStateChange moveset arg. ([5b2db98](https://github.com/christides11/hack-and-slash-framework/commit/5b2db98d7f996a5813dc155bffa17cbd71a0a5be))
* MovesetDefinition init function. ([a40d31b](https://github.com/christides11/hack-and-slash-framework/commit/a40d31b92b8eb70c238edb4d602e4cec30e54dde))
* State Condition & Function Mapper. ([0619794](https://github.com/christides11/hack-and-slash-framework/commit/0619794856441f9ba217185ae578d48262b1f5ed))
* Upgraded to 2021.3.0 ([be25609](https://github.com/christides11/hack-and-slash-framework/commit/be2560931c09f6ce1a61d3ea75f2983523783a72))

# [33.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v32.0.0...v33.0.0) (2022-03-18)


### Code Refactoring

* Moved unnecessary variables out of HitInfoBase ([d5c1d5a](https://github.com/christides11/hack-and-slash-framework/commit/d5c1d5abef557673e6b0af633a8ca55fab887e6c))


### Features

* Added ITeamable. ([085e332](https://github.com/christides11/hack-and-slash-framework/commit/085e33206d73ce723aa8f65f904c29f6c240946a))


### BREAKING CHANGES

* Moved GetTeam out of IFighterCombatManager to ITeamable.
* HitInfoBase only has what is required by it.

# [32.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v31.1.1...v32.0.0) (2022-03-10)


### Features

* Removed old attack system. ([4e42389](https://github.com/christides11/hack-and-slash-framework/commit/4e423898b64723c4ff6c7cf4ffde49108c29719b))


### BREAKING CHANGES

* Moved to new state system based on timeline.

## [31.1.1](https://github.com/christides11/hack-and-slash-framework/compare/v31.1.0...v31.1.1) (2022-03-09)


### Bug Fixes

* Removed sample reference in StateConditionAND ([c8b65f7](https://github.com/christides11/hack-and-slash-framework/commit/c8b65f7e50ebed954d7a3e16718f9fa95b9e2b2a))

# [31.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v31.0.1...v31.1.0) (2022-03-09)


### Features

* TimelineClip passthrough. ([48ce5f0](https://github.com/christides11/hack-and-slash-framework/commit/48ce5f0fb545f38dfa19aee18d4165df404b0177))

## [31.0.1](https://github.com/christides11/hack-and-slash-framework/compare/v31.0.0...v31.0.1) (2022-03-09)


### Bug Fixes

* Changed FighterStateBehaviour namespace. ([96e26ec](https://github.com/christides11/hack-and-slash-framework/commit/96e26ecf80fc1dc1b0ff904316dd3ded2d072d46))

# [31.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v30.0.1...v31.0.0) (2022-03-07)


### Code Refactoring

* Changed implementation property drawer ([c09c0c5](https://github.com/christides11/hack-and-slash-framework/commit/c09c0c50c24772a2eeff0dac69d0f6cefe0e670a))


### BREAKING CHANGES

* Changed from Juce implementation selector to medvedya.

## [30.0.1](https://github.com/christides11/hack-and-slash-framework/compare/v30.0.0...v30.0.1) (2022-02-20)


### Bug Fixes

* CamelCase semantic push. ([2939914](https://github.com/christides11/hack-and-slash-framework/commit/2939914db50d0a6d8351a7616e5caeeeb15185cb))

# [30.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v29.0.0...v30.0.0) (2022-02-19)


### Bug Fixes

* Attempting to fix semantic release. ([b45fa00](https://github.com/christides11/hack-and-slash-framework/commit/b45fa008fc64cd1ac3f9578c95e30efbd2a8cbdb))


### Code Refactoring

* Removed implemented fighter classes. ([329c74a](https://github.com/christides11/hack-and-slash-framework/commit/329c74ad7457dec36f4f1d4bfa2d207fa670adb1))
* Removed SImulation related scripts. ([e2f7ef8](https://github.com/christides11/hack-and-slash-framework/commit/e2f7ef8706ebe2cd478cd20606e7a5c92e2d515d))


### Features

* added base classes for state timeline tracks. ([77924d8](https://github.com/christides11/hack-and-slash-framework/commit/77924d873c30c3b585823f6cd9dbe71a31f162f0))
* Added getters for fighter managers in IFighterBase. ([19af502](https://github.com/christides11/hack-and-slash-framework/commit/19af5028be34b514fd4ee27f489f831e53152d83))
* Change to using timeline for states ([a7e01f3](https://github.com/christides11/hack-and-slash-framework/commit/a7e01f34ad1970f77159a6910580e44f0f1ccff0))
* Change to using timeline for states. ([2716794](https://github.com/christides11/hack-and-slash-framework/commit/2716794848dcbac21077da1b3376760ebbd5036f))
* Removed BoxCollectionDefinition ([115ce7b](https://github.com/christides11/hack-and-slash-framework/commit/115ce7b7601d37cfde00caad2c6edc3a9d54785b))
* State Conditions ([5a80c8e](https://github.com/christides11/hack-and-slash-framework/commit/5a80c8ef3c5cd7cef25867c68e09c960bd35a858))
* Upgraded to 2020.3.28f1. ([3d999d6](https://github.com/christides11/hack-and-slash-framework/commit/3d999d62a38385a22d995ab4ead2492a824dace3))


### BREAKING CHANGES

* fixing semantic release.
* Changed to using timeline for states. Makes it easier to preview things in the editor, along with making attack states simpler to handle.
* Removed BoxCollectionDefinition. Unnecessary due to how states now work.
* Removed scripts relating to simulation.
* Removed implemented fighter classes (hurtboxmanager, statemanager, etc.). Actual implementation depends from game to game, rather put things like this in a sample.

# [29.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v28.3.1...v29.0.0) (2021-10-22)


### Features

* Changed StateHurtboxDefinition to BoxCollectionDefinition ([2fc6494](https://github.com/christides11/hack-and-slash-framework/commit/2fc64944d8cf218dd14b6ffabb3ae0bf46ea95f5))


### BREAKING CHANGES

* Changed StateHurtboxDefinition to BoxCollectionDefinition.

## [28.3.1](https://github.com/christides11/hack-and-slash-framework/compare/v28.3.0...v28.3.1) (2021-10-10)


### Bug Fixes

* Attack useState doesn't block out all other properties ([baf0696](https://github.com/christides11/hack-and-slash-framework/commit/baf0696d13171a101f6988ee0e2ab268d27fb30e))

# [28.3.0](https://github.com/christides11/hack-and-slash-framework/compare/v28.2.1...v28.3.0) (2021-10-09)


### Features

* Added pushPullCenterOffset for HitInfo ([89c6209](https://github.com/christides11/hack-and-slash-framework/commit/89c62092e83a67ddae0a9dbcd5081d8fcabea106))

## [28.2.1](https://github.com/christides11/hack-and-slash-framework/compare/v28.2.0...v28.2.1) (2021-10-09)


### Bug Fixes

* Use PropertyField for autoLinkPercentage instead of Slider. ([85afe3c](https://github.com/christides11/hack-and-slash-framework/commit/85afe3ce47958a508a51a4fcbd8c8fd92b112463))

# [28.2.0](https://github.com/christides11/hack-and-slash-framework/compare/v28.1.0...v28.2.0) (2021-10-09)


### Features

* Added autolinkPercentage to HitInfoBase ([f2f7035](https://github.com/christides11/hack-and-slash-framework/commit/f2f70355d8a4e9ecdaf738ff1f63546e372cfeac))

# [28.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v28.0.0...v28.1.0) (2021-09-03)


### Features

* Added inverse option to AttackCondition ([9dc81f3](https://github.com/christides11/hack-and-slash-framework/commit/9dc81f3ac2ae4623611ce6a7cfc1803c70d94d18))

# [28.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v27.0.0...v28.0.0) (2021-09-02)


### Features

* Added attack conditions to cancel list definition. ([7e027b7](https://github.com/christides11/hack-and-slash-framework/commit/7e027b7e2c864bad184769c78ccd6ce5785b7a58))
* Added GetBounds to ITargetable ([08dd20c](https://github.com/christides11/hack-and-slash-framework/commit/08dd20cf41667b8b3e1a69a509c83fc0aa97867e))
* Added IHealable ([824c0e0](https://github.com/christides11/hack-and-slash-framework/commit/824c0e055e44eb67c5a3f091554b8a2f2bf73b10))
* FighterStateBase's OnUpdate doesn't call CheckInterrupt anymore. ([51e16f4](https://github.com/christides11/hack-and-slash-framework/commit/51e16f44d48d845f181442a51989e6c69b05b843))
* Removed commandAttackCancelWindows ([28d5530](https://github.com/christides11/hack-and-slash-framework/commit/28d553056eee28f5b9688fde2398ecf4afa5d1f2))
* Removed inputCheckProccessed ([b7ebb42](https://github.com/christides11/hack-and-slash-framework/commit/b7ebb42a8e4cf495201d765c183d22246d0acf04))
* Removed LookHandler ([4af5e77](https://github.com/christides11/hack-and-slash-framework/commit/4af5e776b92b9f10e5a1733ded86e74542fd98c8))
* Removed unnecessary IFighterBase methods ([739fca7](https://github.com/christides11/hack-and-slash-framework/commit/739fca7550c11f06dfbc5ede13b5915ebb85f63f))
* Removed unnecessary IFighterStateManager methods and added RemoveState ([ac6dfa1](https://github.com/christides11/hack-and-slash-framework/commit/ac6dfa1b8ef442a9ee87b79d8cb3d9d6356543ef))


### BREAKING CHANGES

* Removed methods in IFighterBase that are not necessary.
* Removed Tick and LateTick from IFighterStateManager, and added RemoveState.
* Removed heal method from IHurtable and make an IHealable interface for it.
* Removed inputCheckProccessed from AttackEventDefinition. This should be tracked in an actual script.
* Removed commandAttackCancelWindows. Use the cancel list feature instead.

# [27.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v26.0.0...v27.0.0) (2021-09-02)


### Features

* removed attack event variables ([6049c15](https://github.com/christides11/hack-and-slash-framework/commit/6049c1512d232037fbaf801230201661223da549))


### BREAKING CHANGES

* Removed attack event variables since they are now useless.

# [26.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v25.0.0...v26.0.0) (2021-08-15)


### Code Refactoring

* Moved fighter managers to interfaces ([609cb84](https://github.com/christides11/hack-and-slash-framework/commit/609cb84593517b4960661e9b42652c150912d763))


### BREAKING CHANGES

* Changed to using interfaces so that the actual manager scripts can be modified more.

# [25.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v24.0.0...v25.0.0) (2021-08-07)


### Code Refactoring

* Removed input handling. ([90200c6](https://github.com/christides11/hack-and-slash-framework/commit/90200c675b1e8f9aecde0afc813c032ff61f1395))


### BREAKING CHANGES

* Removed input handling. How input is handled is dependent on the game, so there is no good general way of doing it.

# [24.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v23.1.0...v24.0.0) (2021-06-22)


### Features

* Hitbox attacker can be defined, along with an ignore list. ([6a2942a](https://github.com/christides11/hack-and-slash-framework/commit/6a2942a1b5a9d04c7dddf56339ba25aa418917b0))


### BREAKING CHANGES

* HitboxManager's CheckForCollision now has the attacker and an ignorelist as parameters. Useful when the attacker is not the one with the HitboxManager script attached.

# [23.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v23.0.0...v23.1.0) (2021-06-14)


### Features

* Added method to check attack node conditions ([f8f8710](https://github.com/christides11/hack-and-slash-framework/commit/f8f8710cc6812bbf3abf9c8162ff975fae10fb5a))

# [23.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v22.1.0...v23.0.0) (2021-06-10)


### Bug Fixes

* HitboxManager's CheckForCollision now properly returns true/false. ([a3baebb](https://github.com/christides11/hack-and-slash-framework/commit/a3baebbd31a8ccc49d935fb2a86810e568787762))


### Features

* HitboxManager event now includes the hit reaction ([06973b4](https://github.com/christides11/hack-and-slash-framework/commit/06973b4ecb576f43aceaf9d2f0c744dbfa8ce17f))


### BREAKING CHANGES

* HitReaction changed to HitReactionBase, and is not a class instead of a struct. Move the responsibility of possible needed hitreaction variables from me to the user.

# [22.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v22.0.0...v22.1.0) (2021-06-10)


### Features

* Added CheckConditions method to AttackEventDefinition ([7b56098](https://github.com/christides11/hack-and-slash-framework/commit/7b56098d4f7eadddedd420a5b95fcababdcb2778))

# [22.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v21.0.0...v22.0.0) (2021-06-10)


### Code Refactoring

* Input buffer clearing, changed InputControlType to FighterControlType ([b3bcf69](https://github.com/christides11/hack-and-slash-framework/commit/b3bcf69b4c6569fd8ae25e4be390eadec3e0065a))
* Removed old editor methods ([5673935](https://github.com/christides11/hack-and-slash-framework/commit/567393574bcf3cbc9985e4b6faf709279915fe1c))


### Features

* Conditions for Attack Events. ([6c2b5ac](https://github.com/christides11/hack-and-slash-framework/commit/6c2b5ac4403c3deca024490d470d3681f216bff8))


### BREAKING CHANGES

* Replaced methods with new ones to work with the type selection menu.
* Input buffer clearing is now for all buttons, instead of being done on a button by button basis. Also changed InputControlType to FighterControlType to better represent what it's for.

# [21.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v20.0.0...v21.0.0) (2021-06-04)


### Bug Fixes

* Fixed HitboxGroupPropertyDrawer overlap ([3aa186a](https://github.com/christides11/hack-and-slash-framework/commit/3aa186ac3341be54fcf42b5e6787fbe030296d2f))


### Features

* Hurtboxes now have an ID priority. ([59c9fe8](https://github.com/christides11/hack-and-slash-framework/commit/59c9fe810996e43575fde030c74ea82645bbff8a))
* Improved extendibility of editors scripts ([faca53e](https://github.com/christides11/hack-and-slash-framework/commit/faca53e86837826ac8320e50d208c28d858db340))


### BREAKING CHANGES

* Hitboxes now go through hurtboxes with the lowest IDs first.
* Adjusted editor scripts to make it easier to extend and replace parts.

# [20.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v19.2.0...v20.0.0) (2021-06-02)


### Code Refactoring

* Hurtbox manager changes ([62e910d](https://github.com/christides11/hack-and-slash-framework/commit/62e910d349e48e1a97b18551571adae787fe02f7))


### BREAKING CHANGES

* Fixed issues with hurtbox manager, and allow a window to be infinite with a -1 end frame.

# [19.2.0](https://github.com/christides11/hack-and-slash-framework/compare/v19.1.1...v19.2.0) (2021-05-27)


### Features

* Added LateUpdate for states. ([7643802](https://github.com/christides11/hack-and-slash-framework/commit/76438021281ed71556d438f7eb2682973c07480d))

## [19.1.1](https://github.com/christides11/hack-and-slash-framework/compare/v19.1.0...v19.1.1) (2021-05-27)


### Bug Fixes

* Input buffer check now works correctly. ([fd52b15](https://github.com/christides11/hack-and-slash-framework/commit/fd52b1525d5c3983a6922dafa94cf76bf1a72f9e))

# [19.1.0](https://github.com/christides11/hack-and-slash-framework/compare/v19.0.2...v19.1.0) (2021-05-26)


### Features

* Added getter for attack identifier ([af3c1ef](https://github.com/christides11/hack-and-slash-framework/commit/af3c1ef87f9541af6d1a2932da0517d4cb7db63c))

## [19.0.2](https://github.com/christides11/hack-and-slash-framework/compare/v19.0.1...v19.0.2) (2021-05-26)


### Bug Fixes

* Changed hitboxmanager variables to public ([951083e](https://github.com/christides11/hack-and-slash-framework/commit/951083e5ff3510657d614e9e34dc62fadd4e52db))

## [19.0.1](https://github.com/christides11/hack-and-slash-framework/compare/v19.0.0...v19.0.1) (2021-05-25)


### Bug Fixes

* Attack editor movement changes ([cea8e76](https://github.com/christides11/hack-and-slash-framework/commit/cea8e7650efd6ef6481118b6480cac88953f31e8))

# [19.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v18.0.0...v19.0.0) (2021-05-13)


### Code Refactoring

* Hitbox editor improvements ([affa0dc](https://github.com/christides11/hack-and-slash-framework/commit/affa0dcae31a36c102f03d8500e178b347ff4f45))
* IsGrounded moved from FighterBase to FighterPhysicsManager. ([5d9a763](https://github.com/christides11/hack-and-slash-framework/commit/5d9a76387e2a494502ce8701f04d73ffa996787a))
* LateTickSimObjects handled directly in Tick ([d100bd5](https://github.com/christides11/hack-and-slash-framework/commit/d100bd56a9c45c66e77e37b122da57d466a6c419))
* Moved LookHandler into Fighters namespace ([2205ef6](https://github.com/christides11/hack-and-slash-framework/commit/2205ef66d3d0e02ee85faeeb685dd33255dde9d3))


### Features

* Created HitboxManager class. ([2578004](https://github.com/christides11/hack-and-slash-framework/commit/2578004c14252ae83b478674c0a92aebc6ed8200))


### BREAKING CHANGES

* Moved LookHandler since it was the only script in it's namespace and it's usage is for fighters.
* Improved editors and got rid of hitinfo variables that aren't necessary.
* Separated out the functionality in FighterHitboxManager into a HitboxManager class. Now you can use the logic for anything that may want to handle hitboxes, and just have to override the methods that have to be changed. Also changed it to a monobehaviour.
* Moved IsGrounded to FighterPhysicsManager, as it makes more sense to be there.
* Removed LateTick method. The method it calls should be called right after SimulatePhysics anyway.

# [18.0.0](https://github.com/christides11/hack-and-slash-framework/compare/v17.0.0...v18.0.0) (2021-05-08)


### Code Refactoring

* Changed name to HnSF ([f13b8be](https://github.com/christides11/hack-and-slash-framework/commit/f13b8be0daeb5e814ff818a2b3cdbe9fd849eea5))


### BREAKING CHANGES

* Changed name from character action framework to hack and slash framework, since it is a much more well known term and easier to say.

# [17.0.0](https://github.com/christides11/Character-Action-Framework/compare/v16.0.0...v17.0.0) (2021-05-08)


### Features

* Added cancel list. ([2cccac8](https://github.com/christides11/Character-Action-Framework/commit/2cccac8f5dc95b7b8a591b78d9137fa6325caf29))


### BREAKING CHANGES

* Attacks can now refer to a cancel list on what they are able to cancel into and when, instead of a standardized "CommandNormals" list. This gives much more flexibility.

# [16.0.0](https://github.com/christides11/Character-Action-Framework/compare/v15.0.0...v16.0.0) (2021-05-07)


### Code Refactoring

*  CurrentMoveset now referred to by it's index. ([15d20f6](https://github.com/christides11/Character-Action-Framework/commit/15d20f6b3237e69b47c576376cfbf0291b98be04))
* Changed to using PropertyDrawers and SerializedObjects for editors. ([12c9483](https://github.com/christides11/Character-Action-Framework/commit/12c9483f81c4c50a0c007fbd87fa32b0955556d9))
* Hitstun/Hitstop handling changes ([faa02a6](https://github.com/christides11/Character-Action-Framework/commit/faa02a6bd3781ff790ab148647a24b45a330883e))
* MovesetAttackNodes now refered to by their ID. ([8a595df](https://github.com/christides11/Character-Action-Framework/commit/8a595dfd7e960e85fa6387aff515bf09fb048e11))


### Features

* Attack Editor now allows you to move the visual horizontally. ([9b81cf3](https://github.com/christides11/Character-Action-Framework/commit/9b81cf33aaec1079ec3073bbb07542a2a930d7f5))


### BREAKING CHANGES

* Now using propertydrawers and serializedobjects for editor. Makes undoing/redoing changes possible, and makes code for attack event editors able to be separate from the class itself.
* Current moveset tracked by it's index now for networking purposes.
* The current attack is now tracked by it's identifier instead of a direct reference to it. This was done to make it easier to send and receive the current attack through the network.
* Hitstun/hitstop can not be set directly in FighterCombatManager, use the methods instead.

# [15.0.0](https://github.com/christides11/Character-Action-Framework/compare/v14.2.1...v15.0.0) (2021-05-03)


### Code Refactoring

* Better Attack Editor and hitbox handling ([bef7b2c](https://github.com/christides11/Character-Action-Framework/commit/bef7b2cf6128fd8fcfcf73b3e1f13d8a7e1e5004))


### BREAKING CHANGES

* Major refactor of the attack editor and how hitboxes are handled.

## [14.2.1](https://github.com/christides11/Character-Action-Framework/compare/v14.2.0...v14.2.1) (2021-04-30)


### Bug Fixes

* Attack general parameters are now shown if not using a state override. ([795fee6](https://github.com/christides11/Character-Action-Framework/commit/795fee64b35dc5d21ed85ee1ec02690b774d1f08))

# [14.2.0](https://github.com/christides11/Character-Action-Framework/compare/v14.1.0...v14.2.0) (2021-04-11)


### Features

* Added SetPosition to LookHandler. ([e3e0533](https://github.com/christides11/Character-Action-Framework/commit/e3e0533e378922c77ce76c90a49474532ed3e440))

# [14.1.0](https://github.com/christides11/Character-Action-Framework/compare/v14.0.0...v14.1.0) (2021-04-08)


### Features

* Added methods to set LookHandler rotation. ([5000570](https://github.com/christides11/Character-Action-Framework/commit/50005705b5bcf295de78fd3a4deb80af9bebff0a))

# [14.0.0](https://github.com/christides11/Character-Action-Framework/compare/v13.0.0...v14.0.0) (2021-04-03)


### Code Refactoring

* Input handling changes. ([282cf1c](https://github.com/christides11/Character-Action-Framework/commit/282cf1c2e03ca7fa5e367f4bf02483ec3e3b96b0))


### BREAKING CHANGES

* InputRecord changed to circular buffer.

# [13.0.0](https://github.com/christides11/Character-Action-Framework/compare/v12.0.0...v13.0.0) (2021-03-23)


### Code Refactoring

* Reference current state using ushort instead of state itself. ([3d08151](https://github.com/christides11/Character-Action-Framework/commit/3d08151eec2a444f86978b6ec77c960d685fe364))


### BREAKING CHANGES

* Changed the state identifier from a int to a ushort.
CurrentState now refered to by it's number instead of saving a reference to it.
Removed changing state by providing a state directly.

# [12.0.0](https://github.com/christides11/Character-Action-Framework/compare/v11.0.0...v12.0.0) (2021-03-21)


### Code Refactoring

* SimulationManager changes. ([9d5dc63](https://github.com/christides11/Character-Action-Framework/commit/9d5dc63a55d6677ef269c701951686e991c6085c))


### BREAKING CHANGES

* SimObject changed to an interface.

# [11.0.0](https://github.com/christides11/Character-Action-Framework/compare/v10.0.0...v11.0.0) (2021-03-16)


### Code Refactoring

* Renaming of fighter fields. ([ee893e4](https://github.com/christides11/Character-Action-Framework/commit/ee893e45625b234bc7d77e7400b055cb459dd95e))


### Features

* Added ISimObjectManager. ([901f0a0](https://github.com/christides11/Character-Action-Framework/commit/901f0a0dbea7c83059dfdb18ef84101f70ce0797))


### BREAKING CHANGES

* Renamed FighterBase fields.

# [10.0.0](https://github.com/christides11/Character-Action-Framework/compare/v9.0.1...v10.0.0) (2021-03-08)


### Code Refactoring

* Renamed Entities to Fighters. ([b41e069](https://github.com/christides11/Character-Action-Framework/commit/b41e069c2809f9131e8632be66371319cf9e45cc))


### BREAKING CHANGES

* Renamed Entities to Fighters to better reflect what they are.

## [9.0.1](https://github.com/christides11/Character-Action-Framework/compare/v9.0.0...v9.0.1) (2021-02-01)


### Bug Fixes

* Fixed ReActivate hitbox error. ([8a2e3ef](https://github.com/christides11/Character-Action-Framework/commit/8a2e3ef76b99ac6a6da97759b5aadaac2a6ac88c))

# [9.0.0](https://github.com/christides11/Character-Action-Framework/compare/v8.1.0...v9.0.0) (2021-02-01)


### Code Refactoring

* Changed CheckHits to Tick, cleanup. ([1105768](https://github.com/christides11/Character-Action-Framework/commit/1105768c5af17496ab468f0cf7a31ddeb1f77661))


### BREAKING CHANGES

* CheckHits in HitboxBase is now called Tick, since it should be called every tick.

# [8.1.0](https://github.com/christides11/Character-Action-Framework/compare/v8.0.0...v8.1.0) (2021-01-07)


### Features

* Attack Event charge level check support. ([d45ddcc](https://github.com/christides11/Character-Action-Framework/commit/d45ddcc8fe4606e935b12fb5d46b9656189600a0))

# [8.0.0](https://github.com/christides11/Character-Action-Framework/compare/v7.0.0...v8.0.0) (2021-01-06)


### Features

* CheckForInputSequence offset support ([69243c2](https://github.com/christides11/Character-Action-Framework/commit/69243c2519b9cfe077edbd3b803cd2098b8cd5f8))


### BREAKING CHANGES

* CheckForInputSequence now has a baseOffset variable, allowing you to check for a sequences that weren't inputed recently.

# [7.0.0](https://github.com/christides11/Character-Action-Framework/compare/v6.4.0...v7.0.0) (2021-01-06)


### Features

* Lookhandler methods for lockon and lookat targets. ([fcd8000](https://github.com/christides11/Character-Action-Framework/commit/fcd80000b91aa52edc1c4e866ab8a9afad696bbb))


### BREAKING CHANGES

* Renamed SetTarget to SetLockOnTarget to better reflect it's usage. Added SetLookAtTarget to set the target the camera will follow.

# [6.4.0](https://github.com/christides11/Character-Action-Framework/compare/v6.3.1...v6.4.0) (2021-01-05)


### Features

* Hitboxes now properly have support for team detection. ([ee19f27](https://github.com/christides11/Character-Action-Framework/commit/ee19f2726ed4c4f69f98693d7ca45a2a0da1db1d))

## [6.3.1](https://github.com/christides11/Character-Action-Framework/compare/v6.3.0...v6.3.1) (2020-12-29)


### Bug Fixes

* Created values for hitstun/hitstop. ([62b7445](https://github.com/christides11/Character-Action-Framework/commit/62b74454808019a44c8d1d261cc2ca3c896daaa0))

# [6.3.0](https://github.com/christides11/Character-Action-Framework/compare/v6.2.0...v6.3.0) (2020-12-26)


### Features

* Initialize hitbox without creating hitbox. ([d4712e7](https://github.com/christides11/Character-Action-Framework/commit/d4712e7982a4b4e00f9f1d0ca56f1aa122bd1664))

# [6.2.0](https://github.com/christides11/Character-Action-Framework/compare/v6.1.0...v6.2.0) (2020-12-13)


### Features

* Upgraded to 2019.4.15f1, Fixed build error. ([399d070](https://github.com/christides11/Character-Action-Framework/commit/399d070c714fef07ca0856cb4969353af9c57359))

# [6.1.0](https://github.com/christides11/Character-Action-Framework/compare/v6.0.0...v6.1.0) (2020-11-14)


### Features

* Added event for max attack charge reached per level. ([5f0e8ee](https://github.com/christides11/Character-Action-Framework/commit/5f0e8ee5a1f06155d4131d0724afae50936b0ae8))
* Inpector code for InputDefinition & InputSequence. ([56cdec2](https://github.com/christides11/Character-Action-Framework/commit/56cdec20b895c3da1682af6b15bb13495cb74968))

# [6.0.0](https://github.com/christides11/Character-Action-Framework/compare/v5.0.0...v6.0.0) (2020-10-31)


### Code Refactoring

* Made BoxDefinitionBase the default assumed class. ([1bf3769](https://github.com/christides11/Character-Action-Framework/commit/1bf3769678ce379fbe4b6b46d1008d09ff686779))
* Removed deltatime from Simulation method variables. ([389c187](https://github.com/christides11/Character-Action-Framework/commit/389c187af64c3d00e923c2beafbefda4cec948d3))
* Removed status effects. ([1b6076d](https://github.com/christides11/Character-Action-Framework/commit/1b6076dca2c82b699ee69951eafef3d544d39f2b))
* Removed styleGain variable from BoxGroup. ([5e02bf1](https://github.com/christides11/Character-Action-Framework/commit/5e02bf1c45d45859413d713410a610e4e4487093))
* Removed variables from AttackDefinition. ([f3ed16f](https://github.com/christides11/Character-Action-Framework/commit/f3ed16f127cfa872fe96661857d46d34917adeea))
* Replaced GetCenter for GetGameObject in ITargetable. ([30de643](https://github.com/christides11/Character-Action-Framework/commit/30de643e44c821861390fcfac5fd5dc19c3d511e))
* Take InputDefinition directly for CheckStickDirection. ([48d7c65](https://github.com/christides11/Character-Action-Framework/commit/48d7c653ec9c851158aa9cb8cd9314c07e0c183e))


### Features

* Added EntityPhysicsManagerBase. ([1f6d586](https://github.com/christides11/Character-Action-Framework/commit/1f6d586344b43512cb7115501ea99da31bf036c1))
* Added HurtInfoBase to store hurt information. ([b28032b](https://github.com/christides11/Character-Action-Framework/commit/b28032ba8b2084a6109e6b5381e38720d1f3a1e2))
* Added StateHurtboxDefinition. ([36e3dff](https://github.com/christides11/Character-Action-Framework/commit/36e3dffc02db9ba9d2da17e5c71b1c4ba0c76d8f))
* Editor for StateHurtboxDefinition. ([9d26e39](https://github.com/christides11/Character-Action-Framework/commit/9d26e391eebf39463275503720f27ad0b9488bde))
* Functionally of EntityHurtboxManager. ([8d7e273](https://github.com/christides11/Character-Action-Framework/commit/8d7e27355742a0507a3c166887ad98423b124d20))


### BREAKING CHANGES

* Status effects should be handled user-side, outside of what CAF needs to do.
* PhysicsManager now allows for your own implementation, with two given implementations for 3D and 2D.
* Instead of passing the huirt variables directly in OnHurt, instead allow the user to define what should be passed in their own HurtInfoBase. Avoids assuming how the user will implement this method.
* Take InputDefinition directly now for CheckStickDirection. Avoids forcing floats in the user's system.
* With this, the center of the object and any other needed data can be grabbed, while also not assuming the numeric type to be a Vector3.
* Removed deltatime variables from method relating to the simulation. Part of changes to make using fixed point variables easier.
* BoxDefinition was replaced with BoxDefinitionBase in any case that it was reference. This change was made mainly to allow changing the type of the variables used (important if you want fixed point variables).
* Removed both heightRestriction and gravityScaleAdded from AttackDefinition. Should be implemented by the user.
* Removed styleGain variable from BoxGroup. This should be defined by the user as they might either not use a style meter at all or not want to use floats.

# [5.0.0](https://github.com/christides11/Character-Action-Framework/compare/v4.1.0...v5.0.0) (2020-09-11)


### Code Refactoring

* Changed Hitbox to HitboxBase. ([89c135d](https://github.com/christides11/Character-Action-Framework/commit/89c135dfe2ddb80eb0894f92119d58d5a26956e3))


### Features

* Added reset method to LookHandler. ([317235a](https://github.com/christides11/Character-Action-Framework/commit/317235a1e38b56b24e83c6c114e38881c87f6df2))
* Attack events can now check for input. ([9409de5](https://github.com/christides11/Character-Action-Framework/commit/9409de5c6ee7b93d0b43e6754e96821a6d66af37))


### BREAKING CHANGES

* inputs sequences put into their own class, separate from attacks. Makes it easier to define and read input for things besides attacks.
* Changed Hitbox to HitboxBase to better reflect it's usage.

# [4.1.0](https://github.com/christides11/Character-Action-Framework/compare/v4.0.0...v4.1.0) (2020-08-25)


### Features

* Added methods for inertia redirection. ([2672ff2](https://github.com/christides11/Character-Action-Framework/commit/2672ff27eb0d750817113917339d112bd8d5f9de))

# [4.0.0](https://github.com/christides11/Character-Action-Framework/compare/v3.1.0...v4.0.0) (2020-08-21)


### Code Refactoring

* Changed Team property to a method. ([a22502b](https://github.com/christides11/Character-Action-Framework/commit/a22502be88e631e29a39f2962e0e834e15622d93))
* Changed to using HitInfoBase. ([d1717dd](https://github.com/christides11/Character-Action-Framework/commit/d1717dd26db209cf1aec630376b6e6ab171adfb9))
* Removed HealthManager. ([d3c0749](https://github.com/christides11/Character-Action-Framework/commit/d3c0749377ed077ab72fff19cccb54ae2cc49de6))
* Renamed Controller to Manager. ([903ef44](https://github.com/christides11/Character-Action-Framework/commit/903ef44ed7d0620c55d6d2f082a394245012f625))
* Split Hitbox into 2D and 3D. ([23705e6](https://github.com/christides11/Character-Action-Framework/commit/23705e695d590777e0fb022139e5c44f517b6326))


### Features

* Added charge level vars to EntityCombatManager. ([066b55c](https://github.com/christides11/Character-Action-Framework/commit/066b55cbcfef88a0658705b97898f0f6ff35ff36))
* Added healing support, hit info rework. ([013265d](https://github.com/christides11/Character-Action-Framework/commit/013265d234f1fd7eb5c421dbe468bb3d5becdaa2))
* Added hitstop/stun enter and added events. ([4f5cd7d](https://github.com/christides11/Character-Action-Framework/commit/4f5cd7dbdefc18e76fdf32cf2ad82c45c557f86b))
* Added method to get hit list. ([77d6a90](https://github.com/christides11/Character-Action-Framework/commit/77d6a90f29611aed84811f4ddf564b48023c02ce))
* Added team parameter to Hitbox Initialize. ([56a2699](https://github.com/christides11/Character-Action-Framework/commit/56a2699eefa9cb5c321e5542b0b085f22fcf7ea3))
* Charge Levels ([9b1247a](https://github.com/christides11/Character-Action-Framework/commit/9b1247aba6e3e379fbcb0b27c13ba05816348e73))
* Moveset changing. ([60c2440](https://github.com/christides11/Character-Action-Framework/commit/60c24408ee3906607847b1b18aab36b95fd8d63a))
* Multiple attack editor windows can be opened. ([b8dba47](https://github.com/christides11/Character-Action-Framework/commit/b8dba47fc01a1bc3082dec2c2f85cf03a1e73201))
* StateManager related events. ([5f2d5d9](https://github.com/christides11/Character-Action-Framework/commit/5f2d5d9ab589970fbcf5984a4f95e7efb8da384c))
* Support for charge level related hitboxes. ([28418b2](https://github.com/christides11/Character-Action-Framework/commit/28418b2a0921b96b3725c62d61dedb240495091c))
* Upgraded to 2019.4.7f1. ([b5b8940](https://github.com/christides11/Character-Action-Framework/commit/b5b8940db1467282ec3b36ae07a77a3368dc97ad))
* Upgraded to 2019.4.8f1 ([3d81308](https://github.com/christides11/Character-Action-Framework/commit/3d81308917a258cc509d183e089b2981ddeb9ad6))
* Various events for CombatManager related task. ([4fecc2f](https://github.com/christides11/Character-Action-Framework/commit/4fecc2f4b455b4789ad7d1066578296be272242d))


### BREAKING CHANGES

* Initialize now takes a team parameter. Useful in case you want to assign entities to teams and define who they can attack.
* Renamed anywhere using controller to manager for EntityManager.
* Hitbox is now separated into Hitbox3D and Hitbox2D, with Hitbox being the base class of the two.
* Users may want the entity's team to be exposed in the inspector, and they may also want it to be defined by a enum. This makes sure that case is covered.
* Renamed delegates.
* Removed HealthManager since a user might want to store their health values in many different ways, such as ints or fixed point values.
* Now using HitInfoBase in places where HitInfo was being used. Makes system more extendable.
* HitStop and HitStun are now properties instead of fields.
* Upgraded to 2019.4.7f1.

# [3.1.0](https://github.com/christides11/Character-Action-Framework/compare/v3.0.0...v3.1.0) (2020-08-07)


### Features

* Added data for charged attacks. ([e1ca903](https://github.com/christides11/Character-Action-Framework/commit/e1ca9037decaf7a35681e646d02c6e5e33661ada))

# [3.0.0](https://github.com/christides11/Character-Action-Framework/compare/v2.0.0...v3.0.0) (2020-08-06)


### Code Refactoring

* Removed detect box support. ([3c64b5b](https://github.com/christides11/Character-Action-Framework/commit/3c64b5b1b5a92e79766722c46ccf828a5f2007eb))


### BREAKING CHANGES

* Removed detectbox support. Hitboxes can achieve the same effect with no damage/hitstun.

# [2.0.0](https://github.com/christides11/Character-Action-Framework/compare/v1.0.0...v2.0.0) (2020-08-06)


### Styles

* Formatting. ([e60f3cf](https://github.com/christides11/Character-Action-Framework/commit/e60f3cffed75b5a9350f23d69ea7b5e82392fe82))


### BREAKING CHANGES

* Renamed SetController.

# 1.0.0 (2020-07-30)


### Features

* semantic versioning ([171259b](https://github.com/christides11/Character-Action-Framework/commit/171259b88b777269ab7f233127d771fcb7856548))
