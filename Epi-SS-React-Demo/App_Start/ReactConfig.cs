using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Epi_SS_React_Demo.ReactConfig), "Configure")]

namespace Epi_SS_React_Demo
{
	public static class ReactConfig
	{
		public static void Configure()
		{
		    ReactSiteConfiguration.Configuration
		        .SetReuseJavaScriptEngines(true)
		        .SetAllowJavaScriptPrecompilation(true)
		        .AddScript("~/Static/js/Components/PrimaryCallout.jsx")
                .AddScript("~/Static/js/Components/MainSearch.jsx");

		    JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
		    JsEngineSwitcher.Current.EngineFactories.AddV8();
        }
	}
}