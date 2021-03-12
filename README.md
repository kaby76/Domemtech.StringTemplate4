# Antlr4 StringTemplates for C# Library

This is a fork of the C# String Template repo. The old repo [here](https://github.com/antlr/antlrcs)
has not been maintained for years, doesn't build with the
Net5 SDK or VS2019. Since I only need to use StringTemplate4,
I removed all but the essentials--which you can see it just a huge
ton of junk.

This library is a "netstandard2.0" library. All old targets are useless.
With Net5, this builds everywhere, works everywhere.

## Documentation

Refer to the [StringTemplate Home](http://www.stringtemplate.org/) for
instructions on how to use. Note, the API classes and methods differ from
the doc. E.g., [ST in Java](https://github.com/antlr/stringtemplate4/blob/master/src/org/stringtemplate/v4/ST.java)
is [Template in C#](https://github.com/kaby76/stringtemplate4cs/blob/main/Antlr4.StringTemplate/Template.cs).
Why would it be any other way?


Ken Domino
March 12, 2021
