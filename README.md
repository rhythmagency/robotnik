# Robotnik
An Umbraco package that serves a different robots.txt for each domain.

![Example](assets/images/robots.png?raw=true "Example")

# Usage
Once installed, just add a few text files and add some app settings to your web.config to map them to domains. For example:
```xml
<appSettings>
  <!-- http://staging.somesite.com/robots.txt -->
  <add key="robotnik-staging.somesite.com" value="~/robots-staging.txt" />
  <!-- http://www.somesite.com/robots.txt -->
  <add key="robotnik-www.somesite.com" value="~/robots-production.txt" />
  <!-- You can use this to specify a default to avoid a 404. -->
  <add key="robotnik-default" value="~/robots-staging.txt" />
</appSettings>
```

# Code Conventions
Here are the code conventions when contributing to this repository:
* Spaces instead of tabs.
* Lots of code comments (properties, methods, classes).
* Follow existing standards you see in each file.

![Robotnik Logo](assets/images/robotnik-logo.png?raw=true "Robotnik Logo")