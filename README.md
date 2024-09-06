## What is Haxe?

[Haxe](https://haxe.org/) is a language that can be cross-compiled to C#, Java and a ton of other languages, with a focus on performance.

The generated code seems to be just about navigable, but not particularly easy to read thanks to a lot of garbage. For example, this:
```haxe
class MyOptionsThing {
    var hello:String;
    var goodbye:Bool;
}
```
becomes [this](https://github.com/samblackburn/haxe/blob/main/helloworld.cs/src/HelloWorld.cs#L34-L115) in C# and [this](https://github.com/samblackburn/haxe/blob/main/helloworld.java/src/haxe/root/MyOptionsThing.java) in Java.
