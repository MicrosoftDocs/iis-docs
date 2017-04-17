$cacheEntry.Duration = [TimeSpan]::FromSeconds(10)
$cacheEntry.kernelCachePolicy = 'CacheForTimePeriod'
set-webconfigurationproperty /system.webServer/caching iis:\sites\mysite `
    -name profiles `
    -atElement @{extension='.tif'} `
    -value $cacheEntry