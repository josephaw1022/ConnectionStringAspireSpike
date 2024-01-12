## Point 

This repo illustrates that the connection string provided in the app host cannot be overridden by a user. if you define a connection string or config value that is not defined for your project in the app host, then you will be able to obtain the value.
Otherwise the value will be what is defined in the apphost

## Connection String (Web App Project)

Here we are trying to override cache1 connection string value and trying to create the cache3 connection string value

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "cache1": "localhost:6380",
    "cache3": "localhost:6381"
  }
}

```

## App Host File 
![image](https://github.com/josephaw1022/ConnectionStringAspireSpike/assets/47674962/00d95c9e-4b43-496f-b6e5-4d31453d29d6)


## Web App File
![image](https://github.com/josephaw1022/ConnectionStringAspireSpike/assets/47674962/ff9943cd-0ce4-4cbd-979a-7ed56474841d)

## Web App Endpoint Response
![image](https://github.com/josephaw1022/ConnectionStringAspireSpike/assets/47674962/87b9d41f-dd60-4210-8343-58883701e9ae)


