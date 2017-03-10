using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Schema;

namespace PureSurvyTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSchemaSet schema = new XmlSchemaSet();

            schema.Add("", @"c:\users\smalyala\documents\visual studio 2015\Projects\PureSurvyTestApp\PureSurvyTestApp\Files\XSD\Student.xsd");

            XDocument doc = XDocument.Load(@"c:\users\smalyala\documents\visual studio 2015\Projects\PureSurvyTestApp\PureSurvyTestApp\Files\XML\StudentData.xml");

            bool validateError = false;

            doc.Validate(schema, (s, e) =>
             {
                 Console.WriteLine(e.Message);
                 validateError = true;
             });

            if (validateError)
            {
                Console.WriteLine("well-formed failed");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("well-formed Succeded");
                Console.ReadKey();
            }

        }
    }
}
