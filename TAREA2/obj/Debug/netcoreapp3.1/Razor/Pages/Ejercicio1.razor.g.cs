#pragma checksum "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83fa3e03b9c7548eb1f47b6f73a7347757352d01"
// <auto-generated/>
#pragma warning disable 1591
namespace TAREA2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using TAREA2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using TAREA2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio1")]
    public partial class Ejercicio1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card card-columns");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">Detallar cada palabra que pida, ejercicio 1 </div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group mb-3");
            __builder.AddMarkupContent(7, "<span class=\"input-group-text\" id=\"basic-addon1\"></span>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "placeholder", "Digita tu texto");
            __builder.AddAttribute(12, "aria-label", "Username");
            __builder.AddAttribute(13, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor"
                                             oracion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oracion = __value, oracion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "label");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor"
                                            Calcular

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddContent(22, "Calcular");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.OpenElement(24, "label");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor"
                                            Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.AddContent(29, "Limpiar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-footer");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, "Las vocales que hay son: ");
            __builder.AddContent(35, 
#nullable restore
#line 24 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor"
                                     cv

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, "Las Consonantes que hay son: ");
            __builder.AddContent(39, 
#nullable restore
#line 25 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor"
                                         cc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "p");
            __builder.AddContent(42, "Las Espacios que hay son: ");
            __builder.AddContent(43, 
#nullable restore
#line 26 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor"
                                      cs

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio1.razor"
       

    string oracion = "";
    int cv = 0;
    int cc = 0;
    int cs = 0;

    public void Calcular(){


        var vocales = new[] { 'A', 'E', 'I', 'O', 'U' };
        var conso = new[] { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
        var s = new[] { ' ' };


        oracion = oracion.ToUpper();

        foreach (var v in vocales)
        {
            cv += oracion.Count(x => x == v);
        }
        foreach (var v in conso)
        {
            cc += oracion.Count(x => x == v);
        }
        foreach (var v in s)
        {
            cs += oracion.Count(x => x == v);
        }



    }



    public void Limpiar()
    {
        oracion = "";
        cv = 0;
        cc = 0;
        cs = 0;
    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
