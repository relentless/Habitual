#pragma checksum "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc1f8e515c7ddecab3d9bcc5e40a79ecab17910b"
// <auto-generated/>
#pragma warning disable 1591
namespace Habitual.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Programming\Blazor\Habitual\Habitual.Client\_Imports.razor"
using Habitual.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
using Habitual.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/habits")]
    public partial class Habits : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Habits</h1>\r\n\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 7 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
 foreach (var habit in habitConcepts){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.OpenComponent<Habitual.Client.Pages.HabitConceptEditor>(3);
            __builder.AddAttribute(4, "Concept", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Habitual.Client.HabitConcept>(
#nullable restore
#line 8 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
                                      habit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Habitual.Client.ComponentMode>(
#nullable restore
#line 8 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
                                                    ComponentMode.Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Habitual.Client.HabitConcept>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Habitual.Client.HabitConcept>(this, 
#nullable restore
#line 8 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
                                                                                 UpdateConcept

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<Habitual.Client.Pages.HabitConceptEditor>(8);
            __builder.AddAttribute(9, "Concept", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Habitual.Client.HabitConcept>(
#nullable restore
#line 12 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
                              HabitConcept.Create()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Habitual.Client.ComponentMode>(
#nullable restore
#line 12 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
                                                            ComponentMode.Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Habitual.Client.HabitConcept>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Habitual.Client.HabitConcept>(this, 
#nullable restore
#line 12 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
                                                                                        AddConcept

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Programming\Blazor\Habitual\Habitual.Client\Pages\Habits.razor"
       

    private List<HabitConcept> habitConcepts = new List<HabitConcept>();

    private void AddConcept(HabitConcept concept){
        habitConcepts.Add(concept);
        System.Console.WriteLine("Added " + concept);
        concept = new HabitConcept {Active = true, Start=DateTime.Now};
    }

    private void UpdateConcept(HabitConcept concept){
        var conceptToUpdate = habitConcepts.FirstOrDefault(item => item.Id == concept.Id);
        conceptToUpdate.UpdateFrom(concept);
        System.Console.WriteLine("Updated " + concept);
        concept = new HabitConcept {Active = true, Start=DateTime.Now};
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
