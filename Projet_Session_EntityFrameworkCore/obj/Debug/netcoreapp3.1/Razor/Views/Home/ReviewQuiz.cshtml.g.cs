#pragma checksum "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f1c51090fb6bf46cf8e9dc07bf31c34df0c80c91134e465cf38245f108b716b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReviewQuiz), @"mvc.1.0.view", @"/Views/Home/ReviewQuiz.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\_ViewImports.cshtml"
using Projet_Session_EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\_ViewImports.cshtml"
using Projet_Session_EntityFrameworkCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f1c51090fb6bf46cf8e9dc07bf31c34df0c80c91134e465cf38245f108b716b5", @"/Views/Home/ReviewQuiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"db9bfedb07010a9acc57d7bbdea711c29f764c5d82c72282249b0903485eab16", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ReviewQuiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projet_Session_EntityFrameworkCore.Models.Quiz>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("quizForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Le modèle de cette vue -->\r\n");
            WriteLiteral("    <!-- Le titre de la vue -->\r\n");
#nullable restore
#line 4 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
      
        ViewData["Title"] = "ReviewQuiz";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- Récupère la valeur de la variable quizId depuis le ViewBag -->\r\n");
#nullable restore
#line 9 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
      
        var quizId = ViewBag.quizId;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- Représente le contenu de la vue -->\r\n    <div class=\"container\">\r\n        <h1 class=\"display-4\">Réviser un quiz</h1>\r\n    <p><strong><span class=\"green-text\">1. Trouver les quizs à réviser d\'un utilisateur.</span></strong></p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c51090fb6bf46cf8e9dc07bf31c34df0c80c91134e465cf38245f108b716b55963", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""userName"">Nom d'utilisateur:</label>
                <input type=""text"" id=""userName"" name=""userName"" class=""form-control"" required />
            </div>

            <div class=""form-group"">
                <label for=""email"">Email:</label>
                <input type=""email"" id=""email"" name=""email"" class=""form-control"" required />
            </div>


            <p><button type=""button"" id=""filterButton"" class=""btn btn-primary"">Filtrer</button></p>

            <div class=""form-group"">
            <label for=""quiz""><strong><span class=""green-text"">2. Choisir un quiz.</span></strong></label>
                <select id=""quiz"" name=""quizID"" class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c51090fb6bf46cf8e9dc07bf31c34df0c80c91134e465cf38245f108b716b57058", async() => {
                    WriteLiteral("Sélectionnez un quiz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <!-- Boucle pour afficher chaque quiz disponible -->\r\n");
#nullable restore
#line 36 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
                     foreach (var quiz in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c51090fb6bf46cf8e9dc07bf31c34df0c80c91134e465cf38245f108b716b58781", async() => {
                    WriteLiteral("Quiz ");
#nullable restore
#line 38 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
                                                                                                                                                                                         Write(quiz.QuizId);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
                           WriteLiteral(quiz.QuizId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
                                                           Write(quiz.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-user", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
                                                                                       Write(quiz.Email);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-email", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
                                                                                                              Write(Url.Action("ReviewAnswersToQuiz", "Home", new { id = quiz.QuizId }));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-url", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>

        <!--POur cacher le footer et mettre le text en vert-->
        <style>
            .green-text {
                color: limegreen;
            }

            .footer {
                display: none;
            }
        </style>

            <!-- Script pour filtrer les quiz en fonction du nom d'utilisateur et de l'email -->
            <script>
                document.getElementById('filterButton').addEventListener('click', function () {
                    var userName = document.getElementById('userName').value;
                    var email = document.getElementById('email').value;

                    var quizzes = document.getElementById('quiz').options;
                    for (var i = 0; i < quizzes.length; i++) {
                        var quiz = quizzes[i];
                        var user = quiz.getAttribute('data-user');
                        var userEmail = quiz.getAttribute('data-email');
                        ");
                WriteLiteral(@"if ((userName !== '' && user !== userName) || (email !== '' && userEmail !== email)) {
                            quiz.style.display = 'none';
                        } else {
                            quiz.style.display = 'block';
                        }
                    }
                });

                // Script pour mettre à jour l'action du formulaire en fonction de l'option sélectionnée
                document.getElementById('quiz').addEventListener('change', function () {
                    var selectedOption = this.options[this.selectedIndex];
                    var url = selectedOption.getAttribute('data-url');
                    document.getElementById('quizForm').action = url;
                });
            </script>

            <!-- Section boutons-->
            <div class=""form-group"">
                <button type=""submit"" class=""btn btn-primary"">Passer</button>
                <button type=""reset"" class=""btn btn-secondary"">Annuler</button>
            </di");
                WriteLiteral("v>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\ReviewQuiz.cshtml"
AddHtmlAttributeValue("", 609, Url.Action("ReviewAnswersToQuiz", "Home"), 609, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projet_Session_EntityFrameworkCore.Models.Quiz>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
