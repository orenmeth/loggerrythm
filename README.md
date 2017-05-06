# Loggerrythm
Logging class library using Serilog on the .Net Standard plaform.

At the top of the file there should be a short introduction and/ or overview that explains **what** the project is. This description should match descriptions added for package managers (Gemspec, package.json, etc.)

## Code Example
Include the Logarrythm.Core namespace into your console appication's Program.cs file.
```C#
using Loggerrythm.Core;
```
Use the LoggerFactory to create the desired logger implementation.
```C#
static void Main(string[] args)
{
    var elasticLogger = LoggerFactory.Get(LoggerTypes.ElasticLogger);
    var username = "Ólafur";
    elasticLogger.Log(EventLogLevel.Error, $"ElasticLogger: {username}.", username);
}
```

Show what the library does as concisely as possible, developers should be able to figure out **how** your project solves their problem by looking at the code example. Make sure the API you are showing off is obvious, and that your code is short and concise.

## Motivation

A short description of the motivation behind the creation and maintenance of the project. This should explain **why** the project exists.

## Installation

Provide code examples and explanations of how to get the project.

## API Reference

Depending on the size of the project, if it is small and simple enough the reference docs can be added to the README. For medium size to larger projects it is important to at least provide a link to where the API reference docs live.

## Tests

Describe and show how to run the tests with code examples.

## Contributors

Let people know how they can dive into the project, include important links to things like issue trackers, irc, twitter accounts if applicable.

## License

A short snippet describing the license (MIT, Apache, etc.)
