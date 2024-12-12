# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing properties that haven't been explicitly initialized.  While C# generally initializes properties to their default values (0 for ints, null for objects, etc.), relying on this default initialization can be problematic and lead to unexpected behavior, especially in multi-threaded or complex scenarios.

The example shows a class with a property that is accessed within a method, but not set prior. This can lead to unpredictable outcomes depending on the underlying memory state.  The solution file introduces explicit initialization to prevent this issue.
