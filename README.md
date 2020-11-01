# .Net-EmguCV-Tutorial
EmguCV is a .Net wrapper to the OpenCV image processing library.

## Files

```
.
├── src
├── include
├── test
├── img
└── README.md
```

## Dependencies

* [EmguCV](https://www.mlpack.org/)  Version 3.4.1

* [C# .Net Framework](https://www.mlpack.org/)  Version 3.4.1

## Dependencies Installation

* [EmguCV](https://www.mlpack.org/)  Version 3.4.1

```bash
wget https://cmake.org/files/v3.17/cmake-3.17.5.tar.gz
tar xzf cmake-3.17.5.tar.gz
cd cmake-3.17.5
./bootstrap -- -DCMAKE_BUILD_TYPE:STRING=Release
make -j4 # where j is the number of core
sudo make install
```

## Demo

To build run the following command in terminal:

```bash
mkdir build
cd build
cmake ..
make -j4
```

```bash
./kmean --mean 1000 --sigma 500 --distance 200
```

## References

[EmguCV](https://www.mlpack.org/)  Version 3.4.1

[EmguCV](https://www.mlpack.org/)  Version 3.4.1

[EmguCV](https://www.mlpack.org/)  Version 3.4.1

[EmguCV](https://www.mlpack.org/)  Version 3.4.1

## To-Do List

- :ballot_box_with_check: Refactor src/include
- :ballot_box_with_check: Refactor src/include
- :negative_squared_cross_
