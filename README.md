# Blazor Click-Logging Demo
This small demo shows how to log the last 5 UI clicks from a Blazor Server app. It captures each click on the client (in the browser), stores the data (route, CSS class, coordinates, time) in localStorage, and then lets you retrieve it from your C# Blazor code when needed.

# Why Log Clicks?
- Issue Investigation: When a user reports a problem (“I clicked button X and it broke!”), you can quickly see a history of recent clicks to help troubleshoot.
- Lightweight: The app does not constantly ping the server; logs are kept in localStorage until you call for them.
- Minimal Setup: A small JavaScript snippet and a couple lines of C# code handle all the logging and retrieval.

# How It Works
- JavaScript Listener: A short script in your main layout (Layout.razor or _Host.cshtml) intercepts all click events, records them in an array (capped at 5), and saves to localStorage.
- C# Model: A ClickEntry class defines the structure (route, class, x, y, time).
- Retrieval via JS Interop: A ClickLoggerService (or a component) calls localStorage.getItem("lastFiveClicks") through Blazor’s IJSRuntime, deserializes to a List<ClickEntry>, and displays.

# Usage
- Add the JavaScript to your layout.
- Create the ClickEntry model.
- Inject and call the ClickLoggerService (or directly do JS Interop) wherever you want to see the last five clicks.
  
This approach is very handy for diagnosing issues: it gives immediate insight into user actions, letting you reproduce or pinpoint the conditions that led to a problem.
