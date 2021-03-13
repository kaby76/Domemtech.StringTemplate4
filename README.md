# Antlr4 StringTemplates for C# Library

This is a fork of the C# String Template repo. The old repo [here](https://github.com/antlr/antlrcs)
has not been maintained for years, doesn't build with the
Net5 SDK or VS2019. Since I only need to use StringTemplate4, and not the rest of
the software in the repo, I removed all but the essentials for StringTemplate, which you can see
is a ton of unnecessary stuff. It now includes only Antlr4.StringTemplate. Antlr3.Runtime and AntlrBuildTasks
are required by Antlr4.StringTemplate.

This library is a "netstandard2.0" library, which should be compatible with most modern frameworks.
I have uploaded it to NuGet: [Domemtech.StringTemplate4](https://www.nuget.org/packages/Domemtech.StringTemplate4/).

## Documentation

Refer to the [StringTemplate Home](http://www.stringtemplate.org/) for
instructions on how to use. Note, the API classes and methods differ from
the doc. E.g., [ST in Java](https://github.com/antlr/stringtemplate4/blob/master/src/org/stringtemplate/v4/ST.java)
is [Template in C#](https://github.com/kaby76/stringtemplate4cs/blob/main/Antlr4.StringTemplate/Template.cs).
Why would it be any other way?


Ken Domino
March 12, 2021
