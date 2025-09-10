Compile EightBall.java and run it.  It takes an integer as an argument:

java EightBall 391
java EightBall 2000

Normally, this program replies with a message from the files 0, 1, or 2.  However,
due to bad error handling, if you specify a filename instead of an integer as
the argument, it shows the contents of the file.  (For simplicity, the
user input comes from the command-line argument.  What would happen if it
came from a web form?)  Try:

java EightBall /etc/passwd         (on Unix)
java EightBall C:\autoexec.bat     (on Windows)


Run OpenText SAST (Fortify) to scan the code:

$ sourceanalyzer -b EightBall -clean
$ sourceanalyzer -b EightBall -source 1.8 EightBall.java
$ sourceanalyzer -b EightBall -scan-policy classic -scan -f EightBall.fpr

Open the results in Audit Workbench:

$ auditworkbench EightBall.fpr

The output should contain vulnerabilities in the following categories:

      Path Manipulation

The Fortify analysis might detect other issues depending on the Rulepack version 
used in the scan.

The Path Manipulation vulnerability indicates that the user can control
the file opened by the FileReader. 
