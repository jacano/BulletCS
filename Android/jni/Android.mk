#
# Bullet Physics Shared Library
# 

LOCAL_PATH := ../support/bullet-2.83-alpha
include $(CLEAR_VARS)

LOCAL_MODULE    := libbullet
FILE_LIST := $(wildcard $(LOCAL_PATH)/BulletCollision/**/*.cpp)
FILE_LIST += $(wildcard $(LOCAL_PATH)/BulletDynamics/**/*.cpp)
FILE_LIST += $(wildcard $(LOCAL_PATH)/LinearMath/*.cpp)
LOCAL_SRC_FILES := $(FILE_LIST:$(LOCAL_PATH)/%=%)

LOCAL_LDLIBS := -ldl -llog -landroid -lz

include $(BUILD_SHARED_LIBRARY)
