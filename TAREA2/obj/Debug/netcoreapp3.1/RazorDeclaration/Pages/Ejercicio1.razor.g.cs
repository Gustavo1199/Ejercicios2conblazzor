// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
