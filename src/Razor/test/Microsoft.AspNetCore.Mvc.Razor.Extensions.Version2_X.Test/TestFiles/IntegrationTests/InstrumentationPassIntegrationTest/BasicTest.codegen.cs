#pragma checksum "TestFiles/IntegrationTests/InstrumentationPassIntegrationTest/BasicTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78993008d95836bec2b9175d4294bf7bd5f5f109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.TestFiles_IntegrationTests_InstrumentationPassIntegrationTest_BasicTest), @"mvc.1.0.view", @"/TestFiles/IntegrationTests/InstrumentationPassIntegrationTest/BasicTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/TestFiles/IntegrationTests/InstrumentationPassIntegrationTest/BasicTest.cshtml", typeof(AspNetCore.TestFiles_IntegrationTests_InstrumentationPassIntegrationTest_BasicTest))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78993008d95836bec2b9175d4294bf7bd5f5f109", @"/TestFiles/IntegrationTests/InstrumentationPassIntegrationTest/BasicTest.cshtml")]
    public class TestFiles_IntegrationTests_InstrumentationPassIntegrationTest_BasicTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Hello", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("unbound", new global::Microsoft.AspNetCore.Html.HtmlString("foo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::FormTagHelper __FormTagHelper;
        private global::InputTagHelper __InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 28, true);
            BeginContext(31, 28, true);
            WriteLiteral("<span someattr>Hola</span>\r\n");
            EndContext();
            EndContext();
            BeginContext(61, 7, false);
            BeginContext(61, 7, false);
#nullable restore
#line 3 "TestFiles/IntegrationTests/InstrumentationPassIntegrationTest/BasicTest.cshtml"
Write("Hello");

#line default
#line hidden
#nullable disable
            EndContext();
            EndContext();
            BeginContext(69, 2, true);
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            EndContext();
            BeginContext(71, 87, false);
            BeginContext(71, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                BeginContext(91, 6, true);
                BeginContext(91, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                EndContext();
                BeginContext(97, 52, false);
                BeginContext(97, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
                }
                );
                __InputTagHelper = CreateTagHelper<global::InputTagHelper>();
                __tagHelperExecutionContext.Add(__InputTagHelper);
                __InputTagHelper.FooProp = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "TestFiles/IntegrationTests/InstrumentationPassIntegrationTest/BasicTest.cshtml"
__InputTagHelper.BarProp = DateTime.Now;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("date", __InputTagHelper.BarProp, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                EndContext();
                BeginContext(149, 2, true);
                BeginContext(149, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                EndContext();
            }
            );
            __FormTagHelper = CreateTagHelper<global::FormTagHelper>();
            __tagHelperExecutionContext.Add(__FormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            EndContext();
            BeginContext(158, 31, true);
            BeginContext(158, 31, true);
            WriteLiteral("\r\n\r\n<span>Here is some content ");
            EndContext();
            EndContext();
            BeginContext(207, 9, true);
            BeginContext(207, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
            EndContext();
            BeginContext(217, 29, false);
            BeginContext(217, 29, false);
#nullable restore
#line 9 "TestFiles/IntegrationTests/InstrumentationPassIntegrationTest/BasicTest.cshtml"
Write(Foo(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(222, 24, true);
    BeginContext(222, 24, true);
    WriteLiteral("<span>Hello world</span>");
    EndContext();
    EndContext();
    PopWriter();
}
)));

#line default
#line hidden
#nullable disable
            EndContext();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
