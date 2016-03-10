This project illustrates a problem with the following packages:

```
<package id="Xamarin.Android.Support.v4" version="23.2.0-beta1" targetFramework="MonoAndroid60" />
<package id="Xamarin.Android.Support.v7.AppCompat" version="23.2.0-beta1" targetFramework="MonoAndroid60" />
```

When the included project is ran on a device not needing to use the compat libs (API 22, etc), all runs fine, a blue Toolbar is displayed. However, if it is ran on a device needing compat (Nexus 10 API 19, etc), a crash occurs with the following exception:

```
Java.Lang.NoClassDefFoundError: android.support.graphics.drawable.VectorDrawableCompat
```

The full stacktrace can be found in StackTrace.txt.

From this link, it seems with a native app, we'd set `vectorDrawables.useSupportLibrary = true` in the Gradle config:

http://android-developers.blogspot.com/2016/02/android-support-library-232.html

Additionally, it seems the entire class `VectorDrawableCompat` is missing from the lib, as seen by DotPeek-ing it, as shown in Screenshot.png