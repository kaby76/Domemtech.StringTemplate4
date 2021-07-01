using Antlr4.StringTemplate;
using System;

namespace Tester
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            {
                var template = new Template("<asdf>");
                template.Add("asdf", 1);
                var res = template.Render();
                Console.WriteLine(res);
            }
            {
                var tree = Parsing.Parse("1+2");
                var template = new Template("<first(asdf.expression).Text>");
                template.Add("asdf", tree);
                var res = template.Render();
                Console.WriteLine(res);
            }
            {
                var tg = new TemplateGroupString(@"
decl(name, value) ::= ""<name> = <value>;""
");
                var template = tg.GetInstanceOf("decl");
                template.Add("name", "a");
                template.Add("value", "1");
                var res = template.Render();
                Console.WriteLine(res);
            }
            {
                var tree = Parsing.Parse("1+2") as ArithmeticParser.File_Context;
                var tg = new TemplateGroupString(@"
ex(c) ::= 
""<if(c.PLUS)><first(c.expression).Text> PLUS <first(rest(c.expression)).Text><endif>""
");
                tg.Verbose = true;
                var template = tg.GetInstanceOf("ex");
                template.Add("c", tree.expression()[0]);
                var res = template.Render();
                Console.WriteLine(res);
            }
            {
                var tree = Parsing.Parse("1+2") as ArithmeticParser.File_Context;
                var tg = new TemplateGroupString(@"
ex(c) ::= ""<if(c.atom)><at(c.atom)><elseif(c.PLUS)><ex(first(c.expression))> PLUS <ex(first(rest(c.expression)))><elseif(c.MINUS)><ex(first(c.expression))> MINUS <ex(first(rest(c.expression)))><elseif(c.TIMES)><ex(first(c.expression))> TIMES <ex(first(rest(c.expression)))><elseif(c.DIV)><ex(first(c.expression))> DIV <ex(first(rest(c.expression)))><elseif(c.POW)><ex(first(c.expression))> POW <ex(first(rest(c.expression)))><elseif(c.LPAREN)><ex(first(c.expression))><endif>""
at(c) ::= ""<c.Text>""
");
                tg.Verbose = true;
                var template = tg.GetInstanceOf("ex");
                template.Add("c", tree.expression()[0]);
                var res = template.Render();
                Console.WriteLine(res);
            }
        }
    }
}
