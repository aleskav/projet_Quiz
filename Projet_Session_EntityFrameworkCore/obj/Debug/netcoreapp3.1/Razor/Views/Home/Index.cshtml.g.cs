#pragma checksum "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a65bb969eb1d3d30cc87178feee01f442dacf299609add18bf9d180b16b9b669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a65bb969eb1d3d30cc87178feee01f442dacf299609add18bf9d180b16b9b669", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"db9bfedb07010a9acc57d7bbdea711c29f764c5d82c72282249b0903485eab16", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet_Session_EntityFrameworkCore.Models.Quiz>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Le modèle de cette vue -->\r\n");
            WriteLiteral("<!-- Le titre de la vue -->\r\n");
#nullable restore
#line 4 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Crée un div avec un texte centré. -->
<div class=""text-center"">

    <!-- Crée une liste -->
    <ul>
        <!-- Le titre du quiz. -->
        <li><h1 class=""display-4"">Bienvenue au Tech Quiz !</h1></li>

        <!-- Une instruction pour les utilisateurs -->
        <li style=""margin-bottom: 10px;"">Créez et répondez à des Quiz en suivant les 3 étapes suivantes.</li>

        <!-- Un lien vers la page pour générer un nouveau quiz. -->
        <li style=""margin-bottom: 10px;""><a");
            BeginWriteAttribute("href", " href=\"", 661, "\"", 698, 1);
#nullable restore
#line 20 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 668, Url.Action("newquiz", "Home"), 668, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1. Générer un nouveau quiz</a></li>\r\n\r\n        <!-- Un lien vers la page pour passer un quiz. -->\r\n        <li style=\"margin-bottom: 10px;\"><a");
            BeginWriteAttribute("href", " href=\"", 842, "\"", 880, 1);
#nullable restore
#line 23 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 849, Url.Action("passquiz", "Home"), 849, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">2. Passer un quiz</a></li>\r\n\r\n        <!-- Un lien vers la page pour réviser un quiz. -->\r\n        <li style=\"margin-bottom: 10px;\"><a");
            BeginWriteAttribute("href", " href=\"", 1016, "\"", 1056, 1);
#nullable restore
#line 26 "C:\Users\alesk\OneDrive\Backup\Projet_de_session_107_AlainPernot_AleskaVargas_NataliaLagrota_ChristineToupin\Projet_Session_EntityFrameworkCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1023, Url.Action("reviewquiz", "Home"), 1023, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">3. Réviser un quiz</a></li>\r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet_Session_EntityFrameworkCore.Models.Quiz> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
