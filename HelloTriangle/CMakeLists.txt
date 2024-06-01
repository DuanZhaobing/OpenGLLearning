cmake_minimum_required(VERSION 3.28)
project(HelloTriangle)

set(CMAKE_CXX_STANDARD 11)
find_package(glfw3 REQUIRED)
file(GLOB project_file glad.c main.cpp)
add_executable(${PROJECT_NAME} ${project_file}
        src/glad.c
        stb_image.cpp
        shader_s.h)
target_link_libraries(${PROJECT_NAME} glfw)