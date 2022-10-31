# Tiktok Unofficial API

## Modules

> Follow User
> Username to ID Converter
> Live Comment

## Sample

User Follow
```
var Follow = User.Follow.FromUsername("coolboy", "yourSessionID").Result;
```

Live Comment
```
var Follow = User.LiveComment.FromRoomId("Hello!", 1000000000000, "yourSessionID").Result;
```

Id Converter
```
var Follow = User.IdConverter.Check("coolboy").Result;
```
