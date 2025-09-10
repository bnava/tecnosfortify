This sample includes simple C# programs that contain System Information Leak vulnerabilities. 
To analyze these programs, you must have .NET SDK 8.0 and MSBuild 17.4 (or later) or Visual Studio 2022 installed.

This sample includes the following C# 12 features:
 - Allow nameof access instance from static
 - Collection expressions
 - Inline arrays
 - Lambda default parameters
 - Primary constructors
 - Ref readonly parameters
 - Using aliases for any types

Translate and scan the solution from the Developer Command Prompt with the following commands:
  $ sourceanalyzer -b Sample -clean
  $ sourceanalyzer -b Sample msbuild /t:restore /t:rebuild CSharp_12.sln
  $ sourceanalyzer -b Sample -sc classic -scan Sample.fpr

Open the results (FPR file) in Audit Workbench.

In this sample, the System Information Leak indicates that sensitive data is written out to the console.
The analysis results might include other issues depending on the version of the Rulepacks used in the scan.