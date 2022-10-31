# Tiktok Unofficial API

## Modules

- [x] Follow User
- [x] Username to ID Converter
- [x] Live Comment

## Sample

User Follow
```cs
var Follow = User.Follow.FromUsername("coolboy", "yourSessionID").Result;
```

Live Comment
```cs
var Follow = User.LiveComment.FromRoomId("Hello!", 1000000000000, "yourSessionID").Result;
```

Id Converter
```cs
var Follow = User.IdConverter.Check("coolboy").Result;
```
