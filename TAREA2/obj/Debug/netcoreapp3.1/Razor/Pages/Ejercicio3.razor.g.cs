#pragma checksum "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73897940c4bd09fb219d3a32b2618a0029aded0d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio3")]
    public partial class Ejercicio3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card card-columns");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">Consultar si la cedula es valida </div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group mb-3");
            __builder.AddMarkupContent(7, "<span class=\"input-group-text\" id=\"basic-addon1\"></span>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "placeholder", "Digita la cedula");
            __builder.AddAttribute(12, "aria-label", "Username");
            __builder.AddAttribute(13, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor"
                                             cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "label");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor"
                                            ValidaCedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddContent(22, "Calcular");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.AddMarkupContent(24, "<label><button type=\"button\" class=\"btn btn-danger\">Limpiar</button></label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-footer");
            __builder.OpenElement(28, "p");
#nullable restore
#line 22 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor"
              
                if (@errores == "")
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<html><p class=\"p-3 mb-2 bg-success text-white\">La cedula esta correcta </p></html>");
#nullable restore
#line 26 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, 
#nullable restore
#line 29 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor"
                     errores

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 29 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor"
                            
                }
            

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\5 cuatrimestre\Programación III\unidad 2\TAREA2\TAREA2\Pages\Ejercicio3.razor"
       

    //Declaracion de la Varibles
    string cedula = "";
    string errores = "";
    bool validacion = false;
    //* Método o función para validar una cédula dominicana*
    public void ValidaCedula()
    {
        //Declaración de variables a nivel de método o función.
        errores = "";
        validacion = false;
        int verificador = 0;
        int digito = 0;
        int digitoVerificador = 0;
        int digitoImpar = 0;
        int sumaPar = 0;
        int sumaImpar = 0;
        int longitud = Convert.ToInt32(cedula.Length);
        /* Control de errores en el código */
        try
        {
            //verificamos que la longitud del parametro sea igual a 11
            if (longitud == 11)
            {
                digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
                //recorremos en un ciclo for cada dígito de la cédula
                for (int i = 9; i >= 0; i--)
                {
                    //si el digito no es par multiplicamos por 2
                    digito = Convert.ToInt32(cedula.Substring(i, 1));
                    if ((i % 2) != 0)
                    {
                        digitoImpar = digito * 2;
                        //si el digito obtenido es mayor a 10, restamos 9
                        if (digitoImpar >= 10)
                        {
                            digitoImpar = digitoImpar - 9;
                        }
                        sumaImpar = sumaImpar + digitoImpar;
                    }
                    /*En los demás casos sumamos el dígito y lo aculamos 
                     en la variable */
                    else
                    {
                        sumaPar = sumaPar + digito;
                    }
                }
                /*Obtenemos el verificador restandole a 10 el modulo 10 
                de la suma total de los dígitos*/
                verificador = 10 - ((sumaPar + sumaImpar) % 10);
                /*si el verificador es igual a 10 y el dígito verificador
                  es igual a cero o el verificador y el dígito verificador 
                  son iguales retorna verdadero*/
                if (((verificador == 10) && (digitoVerificador == 0))
                     || (verificador == digitoVerificador))
                {
                    validacion = true;
                }
                else
                {
                    errores = "Cedula Invalida!...";
                }
            }
            else
            {
                errores = "La cedula debe contener once(11) digitos";
            }
        }
        catch
        {
            errores += "No se pudo validar la cédula";
        }


    }



    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
