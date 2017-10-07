
# react-native-iota

## Getting started

`$ npm install react-native-iota --save`

### Mostly automatic installation

`$ react-native link react-native-iota`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-iota` and add `RNIota.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNIota.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNIotaPackage;` to the imports at the top of the file
  - Add `new RNIotaPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-iota'
  	project(':react-native-iota').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-iota/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-iota')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNIota.sln` in `node_modules/react-native-iota/windows/RNIota.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Iota.RNIota;` to the usings at the top of the file
  - Add `new RNIotaPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNIota from 'react-native-iota';

// TODO: What to do with the module?
RNIota;
```
  