﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\SucceededJobs.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Pages\SucceededJobs.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\Pages\SucceededJobs.cshtml"
    using HangFire.Web.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.3.0")]
    internal partial class SucceededJobs : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





WriteLiteral("              \r\n");


            
            #line 7 "..\..\Pages\SucceededJobs.cshtml"
  
    Layout = new LayoutPage()
        {
            Context = Context,
            Title = "Succeeded Jobs"
        };


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"alert alert-info\">\r\n    HangFire хранит последние 100 успешно выпол" +
"ненных  заданий в очереди <code>hangfire:succeeded</code> \r\n    для более просто" +
"й отладки работы фоновых задач.\r\n</div>\r\n\r\n");


            
            #line 20 "..\..\Pages\SucceededJobs.cshtml"
  
    var succeededJobs = HangFireApi.SucceededJobs();


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 24 "..\..\Pages\SucceededJobs.cshtml"
 if (succeededJobs.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <p>\r\n        Список завершенных за" +
"даний пуст.\r\n    </div>\r\n");


            
            #line 30 "..\..\Pages\SucceededJobs.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Type</th>
                <th>Queue</th>
                <th>Args</th>
                <th>Succeeded at</th>
                <th>Latency</th>
            </tr>
        </thead>
        <tbody>
");


            
            #line 44 "..\..\Pages\SucceededJobs.cshtml"
             foreach (var job in succeededJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");


            
            #line 47 "..\..\Pages\SucceededJobs.cshtml"
                   Write(job.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td><span class=\"label label-primary\">");


            
            #line 48 "..\..\Pages\SucceededJobs.cshtml"
                                                     Write(job.Queue);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                    <td>\r\n                        <code>\r\n         " +
"                   ");


            
            #line 51 "..\..\Pages\SucceededJobs.cshtml"
                       Write(String.Join(", ", job.Args.Select(x => String.Format("{0}: \"{1}\"", x.Key, x.Value))));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </code>\r\n                    </td>\r\n                   " +
" <td>");


            
            #line 54 "..\..\Pages\SucceededJobs.cshtml"
                   Write(job.SucceededAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");


            
            #line 55 "..\..\Pages\SucceededJobs.cshtml"
                   Write(job.Latency);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");


            
            #line 57 "..\..\Pages\SucceededJobs.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 60 "..\..\Pages\SucceededJobs.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
