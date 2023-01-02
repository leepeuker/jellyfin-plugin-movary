# Movary for Jellyfin Plugin

Automatically log in jellyfin watched movies to movary.

### Development
Requirements:
- dotnet 6

Build the plugin

```
git clone git@github.com:leepeuker/jellyfin-plugin-movary.git
make build
```

Copy resulting `./bin/Movary.dll` in the jellyfin plugins folder, e.g. `[...]/plugins/Movary/Movary.dll` and restart jellyfin for testing.
