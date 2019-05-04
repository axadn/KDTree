# KDTree<Component>

### Description (ReDesigned for Unity Components)

3D KDTree for Unity, with fast construction and fast & thread-safe querying, with minimal memory garbage.

### It was designed:
* to be working with Unity Vector3 structs, but can be modified to work with any other 3D (or 2D & 4D or higher) struct/arrays
* for speedy & light Construction & Reconstruction,
* to be light on memory, everything is pooled,
* for fast querying, 
* queryable from multiple threads (thread-safe),

### New Properties:
* New class KDTree<T> (T is a Component type)
* All QueryModes available for Components
* Added Test class for KDTree<T> testing
* Radius search now searching between two radius
* Alternative Query Functions

### Coming Soon:
* 2D search modes XY,XZ,YZ

### Query modes:
* K-Nearest
* Closest point query
* Radius query
* Interval query

### More Details, How To Use, How it works ...

https://github.com/viliwonka/KDTree


### Demos

Drawing traversal nodes of KNearest Query

![alt-text](https://raw.githubusercontent.com/viliwonka/KDTree/master/Media/FrontPic.PNG)

KNearest Query

![alt-text](https://raw.githubusercontent.com/viliwonka/KDTree/master/Media/KNearestQuery.gif)

Radius Query

![alt-text](https://raw.githubusercontent.com/viliwonka/KDTree/master/Media/RadiusQuery.gif)

Interval/Bounds Query

![alt-text](https://raw.githubusercontent.com/viliwonka/KDTree/master/Media/IntervalQuery.gif)



