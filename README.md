# ClassLibrary1

Try to run this command in the solution directory:  
``dotnet stryker --configuration Release --reporter json --reporter html``

```
`Version: 5.1.0

[08:43:16 INF] Analysis starting.  
[08:43:16 INF] Using solution configuration/platform 'Release|Any CPU'.  
[08:43:16 INF] Identifying projects to mutate in ClassLibrary1.slnx. This can take a while.  
[08:43:18 INF] Picking net10.0 for project   C:\workspace\ClassLibrary1\ClassLibrary1\ClassLibrary1.csproj.  
[08:43:18 INF] Found project C:\workspace\ClassLibrary1\ClassLibrary1\ClassLibrary1.csproj to mutate.  
[08:43:18 INF] Analysis complete.  
[08:43:18 INF] Building solution ClassLibrary1.slnx.  
[08:43:19 INF] Building project ClassLibrary1.slnx using dotnet build ClassLibrary1.slnx -c Release --property:Platform="Any CPU" (directory C:\workspace\ClassLibrary1.)  
[08:43:27 INF] Number of tests found: 2 for project C:\workspace\ClassLibrary1\ClassLibrary1\ClassLibrary1.csproj. Initial test run started.  
[08:43:30 INF] Time Elapsed 00:00:15.0127772
Stryker.NET failed to mutate your project. For more information see the logs below:  


Initial test run could not be completed.
````


````
Version: 5.0.0

A new version of Stryker.NET (5.1.0) is available. Please consider upgrading using `dotnet tool update -g 
dotnet-stryker`

[08:49:11 INF] Analysis starting.
[08:49:11 INF] Using solution configuration/platform 'Release|Any CPU'.
[08:49:11 INF] Identifying projects to mutate in ClassLibrary1.slnx. This can take a while.
[08:49:14 INF] Picking net10.0 for project C:\workspace\ClassLibrary1\ClassLibrary1\ClassLibrary1.csproj. 
[08:49:14 INF] Found project C:\workspace\ClassLibrary1\ClassLibrary1\ClassLibrary1.csproj to mutate.
[08:49:14 INF] Analysis complete.
[08:49:14 INF] Building solution ClassLibrary1.slnx.
[08:49:15 INF] Building project ClassLibrary1.slnx using dotnet build ClassLibrary1.slnx -c Release --property:Platform="Any CPU" (directory C:\workspace\ClassLibrary1.)
[08:49:22 INF] Number of tests found: 2 for project C:\workspace\ClassLibrary1\ClassLibrary1\ClassLibrary1.csproj. Initial test run started.
[08:49:25 INF] 6 mutants created
[08:49:25 INF] Capture mutant coverage using 'CoverageBasedTest' mode.
Hint: by passing "--open-report or -o" the report will open automatically and update the report in real-time.
[08:49:28 INF] 1     mutants got status NoCoverage.   Reason: Not covered by any test.
[08:49:28 INF] 2     mutants got status Ignored.      Reason: Removed by block already covered filter
[08:49:28 INF] 3     total mutants are skipped for the above mentioned reasons
[08:49:28 INF] 3     total mutants will be tested

Your json report has been generated at:
C:\workspace\ClassLibrary1\StrykerOutput\2026-11-17.08-49-11\reports\mutation-report.json

Your html report has been generated at:
C:\workspace\ClassLibrary1\StrykerOutput\2026-11-17.08-49-11\reports\mutation-report.html
You can open it in your browser of choice.
[08:49:33 INF] Time Elapsed 00:00:22.1154321
[08:49:33 INF] The final mutation score is 25.00 %
````
