These are register definitions that are made by an automatic tool in Mecrisp-Stellaris, using the ".svd" files that every ARM chip vendor distributes.

The memory map file is useful to cut and paste parts of if you're initializing hardware from scratch.  Similarly the `reg_set` file has the different bit names within each register.  Rather than pull it all in, just use what you need.

Also note that the GPIO registers for the different ports aren't fully specified, but that's because they're all the same with different offsets.  (See the memory map.)  This suggests a function-based approach to me, but I'll have to think about it some more.


