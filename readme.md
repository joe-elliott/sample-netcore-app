# sample-netcore-app

This is a simple netcore web api project.  It only exists to be used as a sample project for profiling.

Check [netcore-kubernetes-profiling](https://github.com/number101010/netcore-kubernetes-profiling) to see it in use.

## endpoints

This simple project only supports two endpoints:

`/api/fibonacci?pos=<value>`

Requires an integer value.  Returns the fibonacci sequence calculated to the requested position.  0 based.

`/api/echecho=<value>`

Echoes the passed in query parameter. s