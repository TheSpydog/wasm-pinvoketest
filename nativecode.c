#include <stdint.h>

typedef struct FNA3D_Device FNA3D_Device;

typedef enum FNA3D_ClearOptions
{
	FNA3D_CLEAROPTIONS_TARGET	= 1,
	FNA3D_CLEAROPTIONS_DEPTHBUFFER	= 2,
	FNA3D_CLEAROPTIONS_STENCIL	= 4
} FNA3D_ClearOptions;

typedef struct FNA3D_Vec4
{
	float x;
	float y;
	float z;
	float w;
} FNA3D_Vec4;

void FNA3D_Clear(
	FNA3D_Device *device,
	FNA3D_ClearOptions options,
	FNA3D_Vec4 *color,
	float depth,
	int32_t stencil
) {
	// stub
}
