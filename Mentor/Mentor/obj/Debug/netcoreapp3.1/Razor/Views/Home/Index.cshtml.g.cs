#pragma checksum "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e433b020c7272926e4fd0c55f1adaf2c7878a29f"
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
#line 1 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
using Mentor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e433b020c7272926e4fd0c55f1adaf2c7878a29f", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/trainers/trainer-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/trainers/trainer-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/trainers/trainer-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main id=""main"">

    <!-- ======= About Section ======= -->
    <section id=""about"" class=""about"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"">
                <div class=""col-lg-6 order-1 order-lg-2"" data-aos=""fade-left"" data-aos-delay=""100"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e433b020c7272926e4fd0c55f1adaf2c7878a29f5638", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-lg-6 pt-4 pt-lg-0 order-2 order-lg-1 content"">
                    <h3>Voluptatem dignissimos provident quasi corporis voluptates sit assumenda.</h3>
                    <p class=""fst-italic"">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
                        magna aliqua.
                    </p>
                    <ul>
                        <li><i class=""bi bi-check-circle""></i> Ullamco laboris nisi ut aliquip ex ea commodo consequat.</li>
                        <li><i class=""bi bi-check-circle""></i> Duis aute irure dolor in reprehenderit in voluptate velit.</li>
                        <li><i class=""bi bi-check-circle""></i> Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate trideta storacalaperda mastiro dolore eu fugiat nulla pariatur.</li>
                    </ul>
                    <");
            WriteLiteral(@"p>
                        Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate
                    </p>

                </div>
            </div>

        </div>
    </section><!-- End About Section -->
    <!-- ======= Counts Section ======= -->
    <section id=""counts"" class=""counts section-bg"">
        <div class=""container"">

            <div class=""row counters"">

                <div class=""col-lg-3 col-6 text-center"">
                    <span data-purecounter-start=""0"" data-purecounter-end=""1232"" data-purecounter-duration=""1"" class=""purecounter""></span>
                    <p>Students</p>
                </div>

                <div class=""col-lg-3 col-6 text-center"">
                    <span data-purecounter-start=""0"" data-purecounter-end=""64"" data-purecounter-duration=""1"" class=""purecounter""></span>
                    <p>Courses</p>
                </div>

                <div class=""col-lg-3 col-6 text-center"">
  ");
            WriteLiteral(@"                  <span data-purecounter-start=""0"" data-purecounter-end=""42"" data-purecounter-duration=""1"" class=""purecounter""></span>
                    <p>Events</p>
                </div>

                <div class=""col-lg-3 col-6 text-center"">
                    <span data-purecounter-start=""0"" data-purecounter-end=""15"" data-purecounter-duration=""1"" class=""purecounter""></span>
                    <p>Trainers</p>
                </div>

            </div>

        </div>
    </section><!-- End Counts Section -->
    <!-- ======= Why Us Section ======= -->
    <section id=""why-us"" class=""why-us"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"">
                <div class=""col-lg-4 d-flex align-items-stretch"">
                    <div class=""content"">
                        <h3>Why Choose Mentor?</h3>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut la");
            WriteLiteral(@"bore et dolore magna aliqua. Duis aute irure dolor in reprehenderit
                            Asperiores dolores sed et. Tenetur quia eos. Autem tempore quibusdam vel necessitatibus optio ad corporis.
                        </p>
                        <div class=""text-center"">
                            <a href=""about.html"" class=""more-btn"">Learn More <i class=""bx bx-chevron-right""></i></a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-8 d-flex align-items-stretch"" data-aos=""zoom-in"" data-aos-delay=""100"">
                    <div class=""icon-boxes d-flex flex-column justify-content-center"">
                        <div class=""row"">
                            <div class=""col-xl-4 d-flex align-items-stretch"">
                                <div class=""icon-box mt-4 mt-xl-0"">
                                    <i class=""bx bx-receipt""></i>
                                    <h4>Corporis voluptates sit</h4>
             ");
            WriteLiteral(@"                       <p>Consequuntur sunt aut quasi enim aliquam quae harum pariatur laboris nisi ut aliquip</p>
                                </div>
                            </div>
                            <div class=""col-xl-4 d-flex align-items-stretch"">
                                <div class=""icon-box mt-4 mt-xl-0"">
                                    <i class=""bx bx-cube-alt""></i>
                                    <h4>Ullamco laboris ladore pan</h4>
                                    <p>Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt</p>
                                </div>
                            </div>
                            <div class=""col-xl-4 d-flex align-items-stretch"">
                                <div class=""icon-box mt-4 mt-xl-0"">
                                    <i class=""bx bx-images""></i>
                                    <h4>Labore consequatur</h4>
                                    <p>Aut suscipit aut cum n");
            WriteLiteral(@"emo deleniti aut omnis. Doloribus ut maiores omnis facere</p>
                                </div>
                            </div>
                        </div>
                    </div><!-- End .content-->
                </div>
            </div>

        </div>
    </section><!-- End Why Us Section -->
    <!-- ======= Features Section ======= -->
    <section id=""features"" class=""features"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"" data-aos=""zoom-in"" data-aos-delay=""100"">
                <div class=""col-lg-3 col-md-4"">
                    <div class=""icon-box"">
                        <i class=""ri-store-line"" style=""color: #ffbb2c;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 6255, "\"", 6262, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem Ipsum</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4 mt-md-0"">
                    <div class=""icon-box"">
                        <i class=""ri-bar-chart-box-line"" style=""color: #5578ff;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 6561, "\"", 6568, 0);
            EndWriteAttribute();
            WriteLiteral(@">Dolor Sitema</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4 mt-md-0"">
                    <div class=""icon-box"">
                        <i class=""ri-calendar-todo-line"" style=""color: #e80368;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 6868, "\"", 6875, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sed perspiciatis</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4 mt-lg-0"">
                    <div class=""icon-box"">
                        <i class=""ri-paint-brush-line"" style=""color: #e361ff;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 7177, "\"", 7184, 0);
            EndWriteAttribute();
            WriteLiteral(@">Magni Dolores</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-database-2-line"" style=""color: #47aeff;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 7474, "\"", 7481, 0);
            EndWriteAttribute();
            WriteLiteral(@">Nemo Enim</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-gradienter-line"" style=""color: #ffa76e;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 7767, "\"", 7774, 0);
            EndWriteAttribute();
            WriteLiteral(@">Eiusmod Tempor</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-file-list-3-line"" style=""color: #11dbcf;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 8066, "\"", 8073, 0);
            EndWriteAttribute();
            WriteLiteral(@">Midela Teren</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-price-tag-2-line"" style=""color: #4233ff;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 8363, "\"", 8370, 0);
            EndWriteAttribute();
            WriteLiteral(@">Pira Neve</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-anchor-line"" style=""color: #b2904f;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 8652, "\"", 8659, 0);
            EndWriteAttribute();
            WriteLiteral(@">Dirada Pack</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-disc-line"" style=""color: #b20969;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 8941, "\"", 8948, 0);
            EndWriteAttribute();
            WriteLiteral(@">Moton Ideal</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-base-station-line"" style=""color: #ff5828;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 9238, "\"", 9245, 0);
            EndWriteAttribute();
            WriteLiteral(@">Verdo Park</a></h3>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 mt-4"">
                    <div class=""icon-box"">
                        <i class=""ri-fingerprint-line"" style=""color: #29cc61;""></i>
                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 9533, "\"", 9540, 0);
            EndWriteAttribute();
            WriteLiteral(@">Flavor Nivelanda</a></h3>
                    </div>
                </div>
            </div>

        </div>
    </section><!-- End Features Section -->
    <!-- ======= Popular Courses Section ======= -->
    <section id=""popular-courses"" class=""courses"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""section-title"">
                <h2>Courses</h2>
                <p>Popular Courses</p>
            </div>

            <div class=""row"" data-aos=""zoom-in"" data-aos-delay=""100"">
");
#nullable restore
#line 201 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
                 foreach(var ml in Model.Courses){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                        <div class=\"course-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e433b020c7272926e4fd0c55f1adaf2c7878a29f18924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10293, "~/assets/img/", 10293, 13, true);
#nullable restore
#line 204 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10306, ml.Img, 10306, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                         <div class=\"course-content\">\r\n                            <div class=\"d-flex justify-content-between align-items-center mb-3\">\r\n                                <h4>");
#nullable restore
#line 207 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
                               Write(ml.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"price\">$");
#nullable restore
#line 208 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
                                             Write(ml.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>

                            <h3><a href=""course-details.html"">Website Design</a></h3>
                            <p>Et architecto provident deleniti facere repellat nobis iste. Id facere quia quae dolores dolorem tempore.</p>
                            <div class=""trainer d-flex justify-content-between align-items-center"">
                                <div class=""trainer-profile d-flex align-items-center"">
");
#nullable restore
#line 215 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
                                     foreach(var item in Model.CouseTeachers){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Antonio</span>\r\n");
#nullable restore
#line 217 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                                <div class=""trainer-rank d-flex align-items-center"">
                                    <i class=""bx bx-user""></i>&nbsp;50
                                    &nbsp;&nbsp;
                                    <i class=""bx bx-heart""></i>&nbsp;65
                                </div>
                            </div>
                         </div>
                        </div>
                    </div> <!-- End Course Item-->
");
#nullable restore
#line 228 "C:\Users\Ravenscroft\Desktop\Back-end\Homework (3)\Mentor\Mentor\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

        </div>
    </section><!-- End Popular Courses Section -->
    <!-- ======= Trainers Section ======= -->
    <section id=""trainers"" class=""trainers"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"" data-aos=""zoom-in"" data-aos-delay=""100"">
                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""member"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e433b020c7272926e4fd0c55f1adaf2c7878a29f23632", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""member-content"">
                            <h4>Walter White</h4>
                            <span>Web Development</span>
                            <p>
                                Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut
                            </p>
                            <div class=""social"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 12771, "\"", 12778, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 12849, "\"", 12856, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 12928, "\"", 12935, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 13008, "\"", 13015, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""bi bi-linkedin""></i></a>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""member"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e433b020c7272926e4fd0c55f1adaf2c7878a29f26390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""member-content"">
                            <h4>Sarah Jhinson</h4>
                            <span>Marketing</span>
                            <p>
                                Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus
                            </p>
                            <div class=""social"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 13837, "\"", 13844, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 13915, "\"", 13922, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 13994, "\"", 14001, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 14074, "\"", 14081, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""bi bi-linkedin""></i></a>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""member"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e433b020c7272926e4fd0c55f1adaf2c7878a29f29138", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""member-content"">
                            <h4>William Anderson</h4>
                            <span>Content</span>
                            <p>
                                Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara
                            </p>
                            <div class=""social"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 14901, "\"", 14908, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 14979, "\"", 14986, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 15058, "\"", 15065, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 15138, "\"", 15145, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""bi bi-linkedin""></i></a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </section><!-- End Trainers Section -->

</main><!-- End #main -->");
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