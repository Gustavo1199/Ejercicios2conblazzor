#pragma checksum "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e35f4345ef9e6dd16e26fd27b75ec2247dfbd8e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio4")]
    public partial class Ejercicio4 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card card-columns");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">Consultar el Tipo de triangulo</div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group mb-3");
            __builder.AddMarkupContent(7, "<span class=\"input-group-text\" id=\"basic-addon1\"></span>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "placeholder", "Digita lado 1");
            __builder.AddAttribute(12, "aria-label", "Username");
            __builder.AddAttribute(13, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor"
                                             ladoa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ladoa = __value, ladoa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "input-group mb-3");
            __builder.AddMarkupContent(19, "<span class=\"input-group-text\" id=\"basic-addon1\"></span>\r\n            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Digita lado 2");
            __builder.AddAttribute(24, "aria-label", "Username");
            __builder.AddAttribute(25, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor"
                                             ladob

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ladob = __value, ladob));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "input-group mb-3");
            __builder.AddMarkupContent(31, "<span class=\"input-group-text\" id=\"basic-addon1\"></span>\r\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "placeholder", "Digita lado 3");
            __builder.AddAttribute(36, "aria-label", "Username");
            __builder.AddAttribute(37, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor"
                                             ladoc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ladoc = __value, ladoc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n        ");
            __builder.OpenElement(41, "label");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor"
                                            triangulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-primary");
            __builder.AddContent(46, "Indentificar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n        ");
            __builder.OpenElement(48, "label");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor"
                                            Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "class", "btn btn-danger");
            __builder.AddContent(53, "Limpiar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "card-footer");
            __builder.OpenElement(57, "p");
            __builder.AddContent(58, "Su triangulo es: ");
            __builder.AddContent(59, 
#nullable restore
#line 31 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor"
                             trian

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
#line 38 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio4.razor"
       

    double ladoa;
    double ladob;
    double ladoc;
    string trian = "";

    void triangulo()
    {

        if (ladoa == ladob && ladob == ladoc)
        {
            trian = "Equilatero";
        }
        else
        {
            if (ladoa == ladob || ladoa == ladoc || ladob == ladoc)
                trian = "Isoceles";

            else
            {
                if (ladoa != ladob || ladoa != ladoc || ladoc != ladob)
                {
                    trian = "Escaleno";
                }
            }
        }

    }

    void Limpiar()
    {
        double ladoa    ;
        double ladob;
        double ladoc;
        string trian = "";
    }






#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
