#pragma checksum "C:\Users\gulbe\OneDrive\Masaüstü\REA\LayeredArchitectureMvcCrud\MVCLayer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3856c0e41f0f7040a70707678200d07fe60b057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gulbe\OneDrive\Masaüstü\REA\LayeredArchitectureMvcCrud\MVCLayer\Views\_ViewImports.cshtml"
using MVCLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gulbe\OneDrive\Masaüstü\REA\LayeredArchitectureMvcCrud\MVCLayer\Views\_ViewImports.cshtml"
using MVCLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3856c0e41f0f7040a70707678200d07fe60b057", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89378d509ed4452b09c23235b2aee5dde980ef71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3856c0e41f0f7040a70707678200d07fe60b0573353", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Bootstrap demo</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""./style.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <style>
       

* {
    font-family: 'Inter', sans-serif;
    box-sizing: border-box;
}

ul, ul li{
    list-style: none;
    padding:0;
}

a{
    text-decoration: none;
    color: inherit;
}

p{
    padding: 0;
    margin: 0;
}


.container-fluid {
    padding-right: 0;
    padding-left: 0;
    --bs-gutter-x: 0rem;
}
.container-full{
    max-width: 100vw
}

.container-full .row {
    margin:0
}


.navbar{
    padding-top:16px;
    padding-bottom:16px ;
}

.dropdo");
                WriteLiteral(@"wn-menu{
    background-color: lightgray;
    box-shadow: 1px 1px 5px rgba(0, 0, 0, 0.6);
    border: none;
}



.carousel-control-next-icon, .carousel-control-prev-icon {
    border-radius: 100%;
}



.carousel-control-next-icon{
    background-image: url('./assets/img/chevron-right.svg');
}

.carousel-control-prev-icon{
    background-image: url('./assets/img/chevron-left.svg');
}


.card{
    inline-size: max-content;
}

/* width */
.container-fluid::-webkit-scrollbar {
    width: 5vw;
  }
  
  /* Track */
  .container-fluid::-webkit-scrollbar-track {
    box-shadow: inset 0 0 5px rgba(128, 128, 128, 0.05); 
    border-radius: 10px;
  }
   
  /* Handle */
  .container-fluid::-webkit-scrollbar-thumb {
    
    border-radius: 10px;
    background:repeating-radial-gradient(transparent,rgba(128, 128, 128, 0.3))

  }


.accordion {
   
    --bs-accordion-border-color: none;
    --bs-accordion-btn-color: white;
    --bs-accordion-btn-bg: none;
    --bs-accordio");
                WriteLiteral(@"n-btn-icon: url(data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='white'%3e%3cpath fill-rule='evenodd' d='M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z'/%3e%3c/svg%3e);
    --bs-accordion-btn-icon-width: 1.25rem;
    --bs-accordion-btn-icon-transform: rotate(-180deg);
    --bs-accordion-btn-icon-transition: transform 0.2s ease-in-out;
    --bs-accordion-btn-active-icon: url(data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='white'%3e%3cpath fill-rule='evenodd' d='M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z'/%3e%3c/svg%3e);
    --bs-accordion-btn-focus-border-color: white;
    --bs-accordion-btn-focus-box-shadow: none;
  
    --bs-accordion-active-color: white;
}

.accordion-item {
    color:white;
    background-color:unset;
    border: none;
    margin:16px 0px
}

.accordio");
                WriteLiteral(@"n-button, .accordion-button:active, .accordion-button:focus{
   border:1px solid white;
   border-radius: 16px;
}

.accordion-item:first-of-type .accordion-button, .accordion-item:last-of-type .accordion-button.collapsed  {
    border-radius: 16px;}

    .accordion-button.collapsed {
        background: white
      }
      
      .accordion-button.collapsed::after {
        background-image: url(""data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='%23fff'%3e%3cpath fill-rule='evenodd' d='M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z'/%3e%3c/svg%3e"");
      }

      .accordion-button:not(.collapsed)::after{
        background-image: url(""data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='%23fff'%3e%3cpath fill-rule='evenodd' d='M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z'/%3e%3c");
                WriteLiteral(@"/svg%3e"");

      }
      .accordion-left-img {
            background-image: url(""https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Ba%C5%9Fak%C5%9FehirCityHospital_%281%29.jpg/1200px-Ba%C5%9Fak%C5%9FehirCityHospital_%281%29.jpg"");
        background-repeat: no-repeat;
        background-size: cover;
    }
  
  

    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3856c0e41f0f7040a70707678200d07fe60b0578935", async() => {
                WriteLiteral(@"
   
    <div class=""container-fluid"">
    <!-- carousel -->
    <div class=""container-fluid"" style=""padding-top:82px ;"">
        <div id=""carouselExampleFade"" class=""carousel slide "" data-bs-ride=""carousel"">
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <div class=""row align-items-center"">
                        <div class=""d-none d-md-block col-md-6 p-0"">
                            <div class="" d-flex flex-column justify-content-center align-items-center h-img-100 bg-white""
                                 style=""padding-left:25% ; "">
                                <h1 class=""my-lg-4  mb-md-3"" style=""align-self: start;"">
                                    We help your
                                    brand to be
                                    recognizable
                                </h1>
                                <p class=""my-lg-4  mb-md-3"">
                                    Lorem ipsum dolor, sit am");
                WriteLiteral(@"et consectetur adipisicing elit. Fugit neque sed hic perferendis distinctio
                                    quae ab possimus eos, consequatur, cumque voluptatem praesentium mollitia.
                                </p>
                                <button class=""btn btn-dark my-lg-4"" style=""align-self: start;"">Contact Us</button>
                            </div>
                        </div>
                        <div class=""col p-0"">
                                <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Ba%C5%9Fak%C5%9FehirCityHospital_%281%29.jpg/1200px-Ba%C5%9Fak%C5%9FehirCityHospital_%281%29.jpg"" class=""d-block w-100 h-img-100 "" alt=""..."">
                            <div class=""carousel-caption d-block d-md-none"">
                                <h1 class=""my-2"">
                                    We help your
                                    brand to be
                                    recognizable
                                </h1>
     ");
                WriteLiteral(@"                           <p class=""my-2"">
                                    Lorem ipsum dolor, sit amet consectetur adipisicing elit. Fugit neque sed hic perferendis distinctio
                                    quae ab possimus eos, consequatur, cumque voluptatem praesentium mollitia.
                                </p>
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""carousel-item"">
                        <img src=""https://i20.haber7.net/resize/1280x720//haber/haber7/photos/2021/51/ruyada_hastane_gormek_ne_demek_ruyada_hastane_koridorlarinda_dolastigini_gormek_1639991559_6476.jpg""
                         class=""d-block w-100 h-img-100 "" alt=""..."">
                    <div class=""carousel-caption"">
                        <h1 class=""my-2 my-lg-4"">
                            We help your
                            brand to be
                            recognizable
                      ");
                WriteLiteral(@"  </h1>
                        <p class=""my-2 my-lg-4"">
                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Fugit neque sed hic perferendis distinctio
                            quae ab possimus eos, consequatur, cumque voluptatem praesentium mollitia.
                        </p>

                    </div>
                </div>

            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleFade"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleFade"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>
    </div>

    
 ");
                WriteLiteral(@"   <!-- Read More text -->
    <div class=""container"">
        <div class=""row"">
            <div class=""col d-flex flex-column justify-content-center align-items-center"" style=""padding: 10%;"">
                <h3 class=""mb-4"">About Company</h3>
                <p class=""mb-5"">
                    Lorem ipsum dolor sit amet consectetur, adipisicing elit. Corrupti vitae quaerat suscipit cum
                    quidem repellendus voluptatibus debitis adipisci non laboriosam? Lorem ipsum, dolor sit amet consectetur
                    adipisicing elit. Tempore, similique. Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam, nemo?
                </p>
                <button class=""btn btn-outline-dark"">Read More</button>
            </div>
        </div>
    </div>
    <!-- Accordion -->
    <div class=""container-full"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-6 accordion-left-img "">
            </div>
            <div class=""col-sm-12 col-md-6 p-5 bg-warnin");
                WriteLiteral(@"g text-white"">
                <h3>Doing the right thing, at the right time</h3>
                <div class=""accordion "" id=""accordionExample"">
                    <div class=""accordion-item "">
                        <h2 class=""accordion-header  "" id=""headingOne"">
                            <button class=""accordion-button bg-warning text-white"" type=""button"" data-bs-toggle=""collapse""
                                    data-bs-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                WEBSITE & MOBILE DESIGN
                            </button>
                        </h2>
                        <div id=""collapseOne"" class=""accordion-collapse collapse show"" aria-labelledby=""headingOne""
                             data-bs-parent=""#accordionExample"">
                            <div class=""accordion-body bg-warning text-white"" style=""border:none ;"">
                                <p>
                                    Lorem ipsum dolor sit amet,");
                WriteLiteral(@" consectetur adipisicing elit. Vero voluptatem totam eum laudantium
                                    expedita consequatur minus repellat, aperiam quam soluta maiores facilis, facere iste libero!
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""accordion-item"">
                        <h2 class=""accordion-header"" id=""headingTwo"">
                            <button class=""accordion-button collapsed bg-warning text-white"" type=""button"" data-bs-toggle=""collapse""
                                    data-bs-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                BRANDING
                            </button>
                        </h2>
                        <div id=""collapseTwo"" class=""accordion-collapse collapse"" aria-labelledby=""headingTwo""
                             data-bs-parent=""#accordionExample"">
                           ");
                WriteLiteral(@" <div class=""accordion-body bg-warning text-white"" style=""border:none ;"">
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vero voluptatem totam eum laudantium
                                    expedita consequatur minus repellat, aperiam quam soluta maiores facilis, facere iste libero!
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class=""accordion-item"">
                        <h2 class=""accordion-header"" id=""headingThree"">
                            <button class=""accordion-button collapsed bg-warning text-white"" type=""button"" data-bs-toggle=""collapse""
                                    data-bs-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                MARKETING
                            </button>
                        </h2>
                       ");
                WriteLiteral(@" <div id=""collapseThree"" class=""accordion-collapse collapse"" aria-labelledby=""headingThree""
                             data-bs-parent=""#accordionExample"">
                            <div class=""accordion-body bg-warning text-white"" style=""border:none ;"">
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vero voluptatem totam eum laudantium
                                    expedita consequatur minus repellat, aperiam quam soluta maiores facilis, facere iste libero!
                                </p>
                            </div>
                        </div>
                    </div>
                </div>



            </div>
        </div>
    </div>
    <!-- our services cards -->
    <div class=""container"" style=""padding: 10%;"">
        <div class=""row my-5 align-items-center"">
            <h3 class=""text-center"">Our Services</h3>
        </div>
        <div class=""row row-cols-1 row-cols-m");
                WriteLiteral("d-3 g-4\">\r\n            <div class=\"col d-flex flex-column justify-content-center align-items-center text-center mb-4\">\r\n                <img src=\"./assets/img/Group 2.png\"");
                BeginWriteAttribute("alt", " alt=\"", 13894, "\"", 13900, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <h4 class=""mb-3 mt-2"">
                    Development</h1>
                    <p style=""font-size:small; font-weight:300"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam
                        accusantium earum quis nulla tempore, consequuntur vitae commodi dolorum molestiae deserunt, ratione
                        doloribus excepturi velit aliquam ipsam ex!
                    </p>
            </div>
            <div class=""col d-flex flex-column justify-content-center align-items-center text-center mb-4"">
                <img src=""./assets/img/Group 2.png""");
                BeginWriteAttribute("alt", " alt=\"", 14536, "\"", 14542, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <h4 class=""mb-3 mt-2"">
                    Development</h1>
                    <p style=""font-size:small; font-weight:300"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam
                        accusantium earum quis nulla tempore, consequuntur vitae commodi dolorum molestiae deserunt, ratione
                        doloribus excepturi velit aliquam ipsam ex!
                    </p>
            </div>
            <div class=""col d-flex flex-column justify-content-center align-items-center text-center mb-4"">
                <img src=""./assets/img/Group 2.png""");
                BeginWriteAttribute("alt", " alt=\"", 15178, "\"", 15184, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <h4 class=""mb-3 mt-2"">
                    Development</h1>
                    <p style=""font-size:small; font-weight:300"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam
                        accusantium earum quis nulla tempore, consequuntur vitae commodi dolorum molestiae deserunt, ratione
                        doloribus excepturi velit aliquam ipsam ex!
                    </p>
            </div>
            <div class=""col d-flex flex-column justify-content-center align-items-center text-center mb-4"">
                <img src=""./assets/img/Group 2.png""");
                BeginWriteAttribute("alt", " alt=\"", 15820, "\"", 15826, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <h4 class=""mb-3 mt-2"">
                    Development</h1>
                    <p style=""font-size:small; font-weight:300"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam
                        accusantium earum quis nulla tempore, consequuntur vitae commodi dolorum molestiae deserunt, ratione
                        doloribus excepturi velit aliquam ipsam ex!
                    </p>
            </div>
            <div class=""col d-flex flex-column justify-content-center align-items-center text-center mb-4"">
                <img src=""./assets/img/Group 2.png""");
                BeginWriteAttribute("alt", " alt=\"", 16462, "\"", 16468, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <h4 class=""mb-3 mt-2"">
                    Development</h1>
                    <p style=""font-size:small; font-weight:300"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam
                        accusantium earum quis nulla tempore, consequuntur vitae commodi dolorum molestiae deserunt, ratione
                        doloribus excepturi velit aliquam ipsam ex!
                    </p>
            </div>
            <div class=""col d-flex flex-column justify-content-center align-items-center text-center mb-4"">
                <img src=""./assets/img/Group 2.png""");
                BeginWriteAttribute("alt", " alt=\"", 17104, "\"", 17110, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <h4 class=""mb-3 mt-2"">
                    Development</h1>
                    <p style=""font-size:small; font-weight:300"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam
                        accusantium earum quis nulla tempore, consequuntur vitae commodi dolorum molestiae deserunt, ratione
                        doloribus excepturi velit aliquam ipsam ex!
                    </p>
            </div>

        </div>


    </div>
    <!-- carousel text -->
    <div class=""container-fluid"" style="" padding: 8%;"">
        <div class=""container"" style=""padding: 5%;"">
            <div class=""row"">
                <div class=""col"">
                    <div id=""carouselExampleControlsNoTouching"" class=""carousel slide"" data-bs-touch=""false"">
                        <div id=""info-carousel"" class=""carousel-inner"">
                            <div class=""carousel-item active"">
                                <p class=""info-carosel-text d-");
                WriteLiteral(@"block w-100"">
                                    Lorem ipsum dolor, sit amet consectetur adipisicing elit.
                                    Vero cum asperiores
                                    velit
                                    magni harum culpa eos aliquam debitis quia dolorum ullam iure dolores, minus nam amet similique? Sed,
                                    veniam
                                    iusto neque ea consequuntur natus? Error, beatae! Iste maxime soluta cumque quod. Quidem nisi deserunt
                                    quaerat? Numquam id nostrum praesentium provident.
                                </p>
                                <br>

                                <p> <strong>Lorem Ipsum</strong> </p>
                            </div>
                            <div class=""carousel-item"">
                                <p class=""info-carosel-text d-block w-100"">
                                    Lorem ipsum dolor, sit amet consectetur adipisic");
                WriteLiteral(@"ing elit.
                                    Vero cum asperiores
                                    velit
                                    magni harum culpa eos aliquam debitis quia dolorum ullam iure dolores, minus nam amet similique? Sed,
                                    veniam
                                    iusto neque ea consequuntur natus? Error, beatae! Iste maxime soluta cumque quod. Quidem nisi deserunt
                                    quaerat? Numquam id nostrum praesentium provident.
                                </p>

                                <br>
                                <p><strong>Lorem Ipsum</strong></p>
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""col-3 info-carousel-right d-flex align-items-center justify-content-center"">
                    <div class=""d-flex flex-column align-items-center"">
                        <h1>0</h1>
                  ");
                WriteLiteral(@"      <button id=""prevCt"" class=""carousel-control-prev mx-3  my-3  my-sm-4 my-lg-5"" type=""button""
                                data-bs-target=""#carouselExampleControlsNoTouching"" data-bs-slide=""prev"" style=""position: relative;"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" fill=""black"" class=""bi bi-arrow-left "" viewBox=""0 0 16 16""
                                 style=""position: absolute;"">
                                <path fill-rule=""evenodd""
                                      d=""M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z"" />
                            </svg>
                        </button>
                    </div>
                    <div class=""d-flex flex-column align-items-center"">
                        <h1 id=""secondText"">1</h1>
                        <button id=""nextCt"" class=""carousel-control-next mx-3 my-3  my-sm-4 my-lg-5"" type=""button""
            ");
                WriteLiteral(@"                    data-bs-target=""#carouselExampleControlsNoTouching"" data-bs-slide=""next"" style=""position: relative;"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" fill=""black"" class=""bi bi-arrow-right "" viewBox=""0 0 16 16""
                                 style=""position: absolute;"">
                                <path fill-rule=""evenodd""
                                      d=""M1 8a.5.5 0 0 1 .5-.5h11.793l-3.147-3.146a.5.5 0 0 1 .708-.708l4 4a.5.5 0 0 1 0 .708l-4 4a.5.5 0 0 1-.708-.708L13.293 8.5H1.5A.5.5 0 0 1 1 8z"" />
                            </svg>
                        </button>
                    </div>
                </div>
            </div>
        </div>

    </div>
    </div>
    <script src=""./info-carousel.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
