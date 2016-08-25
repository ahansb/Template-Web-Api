# Template-Web-Api
Template Web API with individual user accounts(Source) and without(Source2), ninject, automapper set up.

### Step-By-Step
1. Blank Solution - the name of the app
2. Folders - Data, Services, Web
3. Generating Projects
	- for Data - where browse to add \Data
		- the name of the app.Data
		- the name of the app.Models

##### Adding in Web the WebApi
4. Delete
	- Scripts
	- Views
	- Fonts
	- Areas
	- AppData
	- Content
	- favicon
	- Project Readme
	- Bundle Config
	- Filter Config
	- Route Config
	- Home Controller
	- Values Controller???
	
5. After build removing the unused from Global.asax
6. From IdentityModels extract ApplicationUser to Data.Models
7. Adding through Manage NuGet for solution adding EntityFramework and Microsoft.AspNet.Identity.EntityFramework for Data.Models and Data
8. Adding references after build 
9. From IdentityModels extract ApplicationDbContext to Data
10. Fix Usings and References
11. Delete IdentityModels
12. Package Manager Console - enable-migrations for Data
13. Making public static class DatabaseConfig in App_Start with namespace without App_Start at the end
14. In DatabaseConfig -  
		public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }
	and fix the Configuration class into Migrations to be public
15. Global.asax - DatabaseConfig.Initialize();
16. DatabaseConfig - Initialize - ApplicationDbContext.Create().Database.Initialize(true);
17. WebConfig - fixing connectionString
18. IdentityConfig - for password length and so on
19. For registering:
POST - localhost:(your api)/api/Account/Register
	Headers - Content-Type - application/json
	Body - raw JSON - 
					{"email":"ahansb@mail.com",
					 "password":"123456",
					 "confirmPassword":"123456"}
20. For getting authorization:
POST - localhost:(your api)/Token
	Body - x-www-form-urlencoded
		username	ahansb@mail.com
		password	123456	
		grant_type	password
Access Token is received after the post of type Bearer
21. AccountBindingModels - extract all classes with the same namespace
22. AccountViewModels - extract all classes with the same namespace
23. Fix all using in namespaces
24. Adding Data.Common - with GenericRepository copy/paste from old projects and in Contracts IGenericRepository
25. Adding in Services\TemplateWebApi.Services.Data
26. Adding in Data.Models template object with user and in ApplicationUser collection ot templates. Adding Templates into ApplicationDbContext.
27. Adding new TemplateController - Web API 2 Controller with actions, using Entity Framework. Adding [Authorization]
28. Adding Project View Models - TemplateReques and Response view models
29. Adding in Services.Data TemplatesService and ITemplatesService
30. Installing Ninject.Web.WebApi.WebHost in Web.Api
31. In NinjectWebCommon in RegisterServices - kernel.Bind<ITemplatesService>().To<TemplatesService>();
32. Adiing in TemplatesService and ITemplatesService Add function
33. After Exception in NinjectWebCommon updating all 4 ninject
34. If exception when try to start -  Multiple object sets per type are not supported. The object sets 'ApplicationUsers' and 'Users' can both contain instances of type 'TemplateWebApi.Data.Models.ApplicationUser'.,
	remove in ApplicationDbContext -  public System.Data.Entity.DbSet<TemplateWebApi.Data.Models.ApplicationUser> ApplicationUsers { get; set; } 
35. Copy paste ninject register services -
36. Adding IApplicationDbContext 
37. Adding through nuget ninject.extensions.conventions
38. Adding using Ninject.Extensions.Conventions; in NinjectWebCommon
39. Adding new project TemplateWebApi.Common with constants for assemblies
40. In Repository to use IApplicationDbContext not DbContext and property Context
41. Fixing TemplatesController with TemplatesService
42. Installing Automapper in Web.API
43. Making new project TemplateWebApi.Web.Infrastructure with mappings folder and installing Automapper:
	- AutomapperConfig
	- IHaveCustomMappings
	- IMapFrom
	- IMapTo
	- QueryableExtensions
44. Register in Global.asax Automapper - 
			var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(Assembly.GetExecutingAssembly());
45. Making BaseController for automapper	
46. TemplatesController implement with automapper	


