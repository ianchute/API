# Web API Seed
<b>Web API Seed Project</b>

Seed Project for building Multi-tier ASP.NET Web API Applications


<b>Prerequisites:</b>
  1. Visual Studio 2013
  2. NUnit Test Adapater (for built-in config validation tests)

<b>It takes care of infrastructural concerns:</b>
  1. IoC Container Configuration Class (StructureMap)
  2. Mapper Configuration Class (AutoMapper)
  3. Controller Dependecy Resolution (based on IoC Config Class)
  4. Configuration Validation Tests

<b>It also has pre-created folders representing a multitier architecture, as follows:</b>
  1. Data 
  2. Repositories and Applications
  3. Services
  4. Controllers
 
<b>Other features:</b>
  1. CORS Support
  2. Shortened API path (e.g. api.com/{controller}/{id})
  3. Default convention in ContainerConfiguration

<b>How to use:</b>
 1. <b>git clone https://github.com/ianchute/API</b>
 2. Open <b>API.sln</b>
 3. Open the NuGet Console, an alert will pop-up, click 'Restore'.

<b>How to turn into an AngularJS SPA (yeoman style):</b>
 1. Do the above.
 2. Create an ASP.Net MVC Project.
 3. Delete everything in it, remove all references.
 4. Install http://nodejs.org/dist/v0.10.0/x64/node-v0.10.36-x64.msi
 5. If you have NodeJS before, 
      ensure that <b>%appdata%/npm</b> and <b>%appdata%/npm-cache</b> are both empty.
 6. <b>npm install -g yo bower grunt-cli gulp</b>
 7. <b>npm install grunt</b>
 8. <b>npm install -g generator-angular</b>
 9. <b>yo angular</b>

Go to <b>http://yeoman.io/</b> for more info on scaffolding with yo.

For any problems encountered, contact <i>ianchute@hotmail.com</i>.<br>
<b>LinkedIn:</b> <a href="http://ph.linkedin.com/in/ianchute"><img src="https://static.licdn.com/scds/common/u/img/webpromo/btn_liprofile_blue_80x15.png" width="80" height="15" border="0" alt="View Ian Chu Te's profile on LinkedIn"></a><br>
