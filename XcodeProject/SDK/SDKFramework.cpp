//
//  SDKFramework.cpp
//  Unity-iPhone
//
//  Created by zouqiang on 2018/5/23.
//

#include "SDKFramework.hpp"
#include "SDKMessage.h"
#include "SDKConfig.h"
#import <Foundation/Foundation.h>


extern "C"
{
    
    
    SDKMessage * Parse(const char * data)
    {
        SDKMessage * message = new SDKMessage(1);
        
        NSString * jsonString =[NSString stringWithUTF8String: data];

        //将字符串写到缓冲区。
        NSData* jsonData = [jsonString dataUsingEncoding:NSUTF8StringEncoding];
        
        //解析json数据，使用系统方法 JSONObjectWithData:  options: error:
        NSDictionary* dic = [NSJSONSerialization JSONObjectWithData:jsonData options:NSJSONReadingMutableLeaves error:nil];
        
        //接下来一步一步解析。知道得到你想要的东西。
        message->Type =[[dic objectForKey:@"Type"]intValue];
        message->Money =[[dic objectForKey:@"Money"]floatValue];
        message->OrderId =[[dic objectForKey:@"OrderId"] UTF8String];
        
    
        
        
        
        return message;
    }
    
    
    
    
    
    const char* UnityToPhoneSDK(const char*  data)
    {
        NSLog(@"UnityToPhoneSDK data:%s", data);
        
        SDKMessage * message = Parse(data);
        
        SDKMessage::ShowSDKMessageInfo(message);
        
        SDKMessageType type = SDKMessageType(message->Type);
        
        switch (type) {
            case GetChannelName:
                return ChannelName();
            case Login:
                return LoginSDK();
            case Logout:
                return LogoutSDK();
            case UploadInfo:
                return UploadInfoSDK();
            case Pay:
                return PaySDK();
            case Method0:
                return Method0SDK();
            case Method1:
                return Method1SDK();
            case Method2:
                return Method2SDK();
            case Method3:
                return Method3SDK();
            case Method4:
                return Method4SDK();
            default:
                break;
        }
        
        return MakeStringCopy("UnityToPhoneSDK error");
    }
    
    
}

