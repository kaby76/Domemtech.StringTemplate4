# Antlr4 StringTemplates for C# Library

This is a fork of the C# String Template repo. The old repo [here](https://github.com/antlr/antlrcs)
has not been maintained for years, doesn't build with the
Net6 SDK or VS2022. Since I only need to use StringTemplate4, and not the rest of
the software in the repo, I removed all but the essentials for StringTemplate.

* Removed AntlrBuildTasks -- this was used to run the tool and generate parsers for StringTemplate grammars,
which are in Antlr3. Since AntlrBuildTask is removed, the grammars can no longer be updated. This is planned
as any further changes ongoing should be with an Antlr4 grammar.
* Moved Antlr3.Runtime to internal Antlr4.StringTemplate -- this was moved so that there is no external
dependence on the Antlr3 runtime, and no confusion as to what runtime one is using when this library is
used.
* Removed Antlr3.Targets -- not needed.
* Removed Antlr3 -- not needed.
* Removed Antlr3.Tests -- not needed.
* Removed Antlr3.StringTemplate -- not needed.
* Removed Antlr4.StringTemplate.Visualizer -- not needed.
* Removed build -- not needed.

This library is a "netstandard2.0" library, which should be compatible with most modern frameworks.
I have uploaded it to NuGet: [Domemtech.StringTemplate4](https://www.nuget.org/packages/Domemtech.StringTemplate4/).

## History

As far as I can tell, the start of changes in StringTemplate4 for Java that wasn't applied to the
C# version was [this commit](https://github.com/antlr/stringtemplate4/commit/452e4015dbe8ddc35d251f344eee1177dabe69ac#diff-54c975bce4cd656ceab1946ed8471b2efeaf7c66d84f6556adfeb475b8b4ef25). That puts the code divergence since
at least July 16, 2016. 

## Documentation

Refer to the [StringTemplate Home](http://www.stringtemplate.org/) for
instructions on how to use. Note, the API classes and methods differ from
the doc. E.g., [ST in Java](https://github.com/antlr/stringtemplate4/blob/master/src/org/stringtemplate/v4/ST.java)
is [Template in C#](https://github.com/kaby76/stringtemplate4cs/blob/main/Antlr4.StringTemplate/Template.cs).
Why would it be any other way?


Ken Domino
March 12, 2021
