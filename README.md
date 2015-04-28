# Robotnik
An Umbraco package that serves a different robots.txt for each domain.

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