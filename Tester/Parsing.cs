// Template generated code from trgen 0.8.5

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

public class Parsing
{
    public static Parser Parser { get; set; }
    public static Lexer Lexer { get; set; }
    public static ITokenStream TokenStream { get; set; }
    public static IParseTree Tree { get; set; }
    public static IParseTree Parse(string input)
    {
        var str = new AntlrInputStream(input);
        var lexer = new ArithmeticLexer(str);
        Lexer = lexer;
        var tokens = new CommonTokenStream(lexer);
        TokenStream = tokens;
        var parser = new ArithmeticParser(tokens);
        Parser = parser;
        var tree = parser.file_();
        Tree = tree;
        return tree;
    }

    static Antlr4.Runtime.Tree.IParseTree DoParse(string input)
    {
        bool show_tree = false;
        bool show_tokens = false;
        bool old = false;
        bool two_byte = false;
        string file_name = null;
        System.Text.Encoding encoding = null;
        ICharStream str = null;
        if (input == null && file_name == null)
        {
            str = CharStreams.fromStream(System.Console.OpenStandardInput());
        } else if (input != null)
        {
            str = CharStreams.fromString(input);
        } else if (file_name != null)
        {
            if (two_byte)
                str = new TwoByteCharStream(file_name);
            else if (old)
            {
                FileStream fs = new FileStream(file_name, FileMode.Open);
                str = new Antlr4.Runtime.AntlrInputStream(fs);
            }
            else if (encoding == null)
                str = CharStreams.fromPath(file_name);
            else
                str = CharStreams.fromPath(file_name, encoding);
        }
        var lexer = new ArithmeticLexer(str);
        if (show_tokens)
        {
            StringBuilder new_s = new StringBuilder();
            for (int i = 0; ; ++i)
            {
                var ro_token = lexer.NextToken();
                var token = (CommonToken)ro_token;
                token.TokenIndex = i;
                new_s.AppendLine(token.ToString());
                if (token.Type == Antlr4.Runtime.TokenConstants.EOF)
                    break;
            }
            System.Console.Error.WriteLine(new_s.ToString());
            lexer.Reset();
        }
        var tokens = new CommonTokenStream(lexer);
        var parser = new ArithmeticParser(tokens);
        var listener_lexer = new ErrorListener<int>();
        var listener_parser = new ErrorListener<IToken>();
        lexer.AddErrorListener(listener_lexer);
        parser.AddErrorListener(listener_parser);
        DateTime before = DateTime.Now;
        ArithmeticParser.File_Context tree = parser.file_();
        DateTime after = DateTime.Now;
        System.Console.Error.WriteLine("Time: " + (after - before));
        if (listener_lexer.had_error || listener_parser.had_error)
        {
            System.Console.Error.WriteLine("Parse failed.");
        }
        else
        {
            System.Console.Error.WriteLine("Parse succeeded.");
        }
        if (show_tree)
        {
            System.Console.Error.WriteLine(tree.ToStringTree(parser));
        }
        System.Environment.Exit(listener_lexer.had_error || listener_parser.had_error ? 1 : 0);
        return tree;
    }
}
