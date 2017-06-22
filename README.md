# FictionalWeek

- 1 Year = 12 Months
- 1 Month = 4 Weeks
- 1 Week = Unit

## API

```
public void Reset()
public void Next()
public void Prev()
// <param name="year">*|[\d]+</param>
// <param name="month">*|[1-12]</param>
// <param name="week">*|[1-4]</param>
public bool IsMatch(string year, string month, string week)
// <returns>1 - 4</returns>
public int Week()
// <returns>1 - 12</returns>
public int Month()
// <returns>1 - int.MaxValue</returns>
public int Year()
```

## Build DLL for Unity

download [unity-dll](https://raw.githubusercontent.com/ToQoz/bin/master/unity-dll)

```
$ unity-dll FictionalWeek.dll FictionalWeek/*.cs
```
