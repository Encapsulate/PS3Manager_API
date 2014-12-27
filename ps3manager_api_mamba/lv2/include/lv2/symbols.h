/* Keep this file language agnostic. Only preprocessor here. */

#ifndef __FIRMWARE_SYMBOLS_H_S__
#define __FIRMWARE_SYMBOLS_H_S__

#if defined(FIRMWARE_4_50) //Ported by Joonie, Big thanks to @aldostools for his awesome Getsymbols tool, and also Thanks a lot to @Estwald who is the creator of this Mamba payload!!

#define process_rtoc_entry_1				-0x7800 //
#define TOC                                         0x34B160 //done

#define open_shared_kernel_object_symbol            0x12470 // bytes matched: 0x80  F821FF317C0802A6FB8100B0FBC100C0FBE100C8F80100E0789C84027CE03B78
#define close_kernel_object_handle_symbol           0x11A90 // bytes matched: 0x44  F821FF517C0802A6FBA10098FBE100A8FB410080FB610088FB810090FBC100A0

#define alloc_symbol                                0x62F74 // bytes matched: 0x80  2C2300007C85237838C000007C641B784D820020E9229E90E86900004BFFFEB8
#define dealloc_symbol                              0x633B0 // bytes matched: 0x80  E9229E907C85237838C000007C641B78E86900004BFFFBD0F821FF717C0802A6
#define copy_to_user_symbol                         0xF858 // bytes matched: 0x64  2C2500007C0802A6F821FF71FBA10078FBC10080FBE100887C7E1B78FB810070
#define copy_from_user_symbol                       0xFA74 // bytes matched: 0x64  2C2500007C0802A6F821FF71FBA10078FBC10080FBE10088FB8100707C7F1B78
#define copy_to_process_symbol                      0xF910 // bytes matched: 0x80  F821FF317C0802A62C250000FB6100A83F608001FB210098FB8100B0FAE10088
#define copy_from_process_symbol                    0xF720 // bytes matched: 0x80  F821FF417C0802A62C240000FB6100983F608001FB210088FB8100A0FB010080
#define page_allocate_symbol                        0x5EAE4 // bytes matched: 0x60  7C8023787CA92B787CCB33787CE83B787C641B787C0503787D264B787D675B78
#define page_free_symbol                            0x5E548 // bytes matched: 0x80  E9629C607C0802A6F821FF61F80100B0FBC10090FBE10098E92B00007C7F1B78
#define page_export_to_proc_symbol                  0x5EC80 // bytes matched: 0x80  F821FF717C0802A63D20000CF80100A054A0031AFBE100887FA048003D208001
#define page_unexport_from_proc_symbol              0x5E43C // bytes matched: 0x80  E8630030480110542BA3003C7C0802A6F821FF91F80100807C8B23787C601B78
#define kernel_ea_to_lpar_addr_symbol               0x6E868 // bytes matched: 0x80  E922A1407C0802A6F821FF51F80100C0FBC100A0FB610088EBC900007C9B2378
#define map_process_memory_symbol                   0x75988 // bytes matched: 0x7C  7D800026F821FEE1FAC100D07CF63B78FB810100EB82A370FB0100E07C781B78

#define memcpy_symbol                               0x7D048 // bytes matched: 0x80  2BA500077C6B1B78419D002C2C2500007C691B784D8200207CA903A688040000
#define memset_symbol                               0x4D490 // bytes matched: 0x80  2BA500177C6A1B78419D00242FA500004D9E00207C8023787CA903A6980A0000
#define memcmp_symbol                               0x4C7A0 // bytes matched: 0x80  38A500017CA903A642400030880300003863000189240000388400017F890000

#define sprintf_symbol                              0x4E8B8 // bytes matched: 0x80  F821FF817C0802A6F8A100C0F8010090380100C0E8A295A8F8C100C8F8610078
#define snprintf_symbol                             0x4E824 // bytes matched: 0x80  F821FF717C0802A6F8C100D8F80100A0380100D8F8610078908100807CA32B78
#define strcpy_symbol                               0x4D63C // bytes matched: 0x80  880400002F800000980300004D9E00207C691B788C0400012F8000009C090001
#define strncpy_symbol                              0x4D704 // bytes matched: 0x80  2C2500004D820020880400007C6B1B78394000002F80000098030000419E0034
#define strlen_symbol                               0x4D664 // bytes matched: 0x80  7C691B7838600000880900002F8000004D9E00207D234B788C0300012F800000
#define strcat_symbol                               0x4D56C // bytes matched: 0x80  880300007C691B782F800000419E00108C0900012F800000409EFFF888040000
#define strcmp_symbol                               0x4D5E8 // bytes matched: 0x80  880300007C691B78896400007F8B00007C0B0050409E002C2F8B0000409E000C
#define strncmp_symbol                              0x4D690 // bytes matched: 0x80  2C2500004182005089640000892300005560063E7F895800409E00482F800000
#define strchr_symbol                               0x4D5A4 // bytes matched: 0x80  880300002F800000419E00247F802000409E000C48000024419A00208C030001

#define spin_lock_irqsave_ex_symbol                 0x275C08 // bytes matched: 0x80  7D0000A6550004202FA00000419E006C380000027C0101643D60ABAD616BCAFE
#define spin_unlock_irqrestore_ex_symbol            0x275BDC // bytes matched: 0x80  7C2004AC2F850000380000003920000090030000409E000C7C8101644E800020

#define load_process_symbol                         0x5004 // bytes matched: 0x80  7D800026F821FF11FAC100A0FB6100C8FB8100D07C7B1B787CB62B787C9C2378

#define ppu_thread_create_symbol                    0x13F28 // bytes matched: 0x80  7D800026F821FF81FBC10070FBE100787C7E1B787CDF3378918100887C0802A6
#define ppu_thread_exit_symbol                      0x13FE0 // bytes matched: 0x44  F821FF817C0802A6FBE10078F80100907C7F1B78480120258003009054000462
#define ppu_thread_join_symbol                      0x14034 // bytes matched: 0x80  F821FF617C0802A6FB810080F80100B0FBA10088FBC100907C7D1B78FBE10098
#define ppu_thread_delay_symbol                     0x285C8 // bytes matched: 0x64  F821FF017C0802A6FAC100B0FAE100B8FB6100D8FBA100E8FBC100F0FB0100C0

#define create_user_thread2_symbol                  0x24EAC // bytes matched: 0x80  F821FEF17C0802A6FA8100B0F8010120800900287CD43378FAA100B8FAC100C0
#define start_thread_symbol                         0x23B78 // bytes matched: 0x80  7D800026F821FF61FB410070FB610078FB810080FBA10088FBC10090FBE10098
#define run_thread_symbol                           0x233A8 // bytes matched: 0x30  7C641B78E863004848002EB0F821FF717C0802A6FBC100807C7E1B78FBA10078
#define register_thread_symbol                      0x26FE18 // bytes matched: 0x80  7D800026F821FF712C240000FBC10080FBE10088FBA100787C9F23787C7E1B78
#define allocate_user_stack_symbol                  0x270600 // bytes matched: 0x50  F821FF617C0802A6FBA10088F80100B0E803003038C10070FBC100902FA00000

#define mutex_create_symbol                         0x1369C // bytes matched: 0x80  2F8500207C0802A6F821FF71FBA10078FBC10080FBE10088F80100A07CBF2B78
#define mutex_destroy_symbol                        0x13634 // bytes matched: 0x80  F821FF817C0802A6FBE10078F80100907C7F1B78480090012FA300003C008001
#define mutex_lock_symbol                           0x1362C // bytes matched: 0x80  38A000004800A358F821FF817C0802A6FBE10078F80100907C7F1B7848009001
#define mutex_unlock_symbol                         0x13624 // bytes matched: 0x80  48009AA0480096D838A000004800A358F821FF817C0802A6FBE10078F8010090

#define event_port_create_symbol                    0x130D8 // bytes matched: 0x80  F821FF717C0802A6FBA10078FBC1008038A000007C7E1B787C9D237838600020
#define event_port_destroy_symbol                   0x13540 // bytes matched: 0x80  F821FF717C0802A6FBC10080EBC2859038800000F80100A0FBA1007838A00000
#define event_port_connect_symbol                   0x135B8 // bytes matched: 0x80  F821FF617C0802A6FB610078EB62859038A00000F80100B0FB810080FBA10088
#define event_port_disconnect_symbol                0x134E4 // bytes matched: 0x80  F821FF717C0802A6FB810070EB82859038800000F80100A0FBA1007838A00000
#define event_port_send_symbol                      0x130D0 // bytes matched: 0x80  38E0000148017F54F821FF717C0802A6FBA10078FBC1008038A000007C7E1B78

#define event_queue_create_symbol                   0x133E0 // bytes matched: 0x80  F821FF617C0802A6FBE10098F80100B03806FFFF3FE080012B80007E3804FFFF
#define event_queue_destroy_symbol                  0x13368 // bytes matched: 0x80  F821FF717C0802A6FBC10080EBC2859038800000F80100A0FBA1007838A00000
#define event_queue_receive_symbol                  0x131AC // bytes matched: 0x80  F821FF617C0802A6FBE10098F80100B0812300883FE08001380000002F890001

#define cellFsOpen_symbol                           0x29DFE8 // bytes matched: 0x1C  F821FF517C0802A6FB010070FB610088FBA10098FBC100A07C7D1B78
#define cellFsClose_symbol                          0x29DE50 // bytes matched: 0x10  F821FF617C0802A6FBC10090EBC22588
#define cellFsRead_symbol                           0x29DF8C // bytes matched: 0x34  2C2600007C0802A63D208001F821FF71FBE10080F80100A07CDF33786129000D
#define cellFsWrite_symbol                          0x29DEF8 // bytes matched: 0x10  F821FF517C0802A6FBC100A0EBC22588
#define cellFsLseek_symbol                          0x29D580 // bytes matched: 0x10  F821FF517C0802A6FBC100A0EBC22588
#define cellFsStat_symbol                           0x29D804 // bytes matched: 0x18  F821FF617C0802A6FB610078FBA10088FBC100907C7D1B78
#define cellFsUnlink_internal_symbol                0x19BFA4 // bytes matched: 0x2C  F821FEF17C0802A62C240000FBE101083FE08001FB8100F0FBA100F8FBC10100

#define cellFsUtilMount_symbol                      0x29D360 // bytes matched: 0x1C  F821FED17C0802A6FBA101183BA10080FAE100E8FBC101207C972378
#define cellFsUtilUmount_symbol                     0x29D2E8 // bytes matched: 0x20**  7C8023787CA62B787C641B787C05037838E00000E93E80B0EBC1FFF0E8690000
#define pathdup_from_user_symbol                    0x1A20DC // bytes matched: 0x18  F821FF517C0802A6FB210078FB410080FBC100A07C7A1B78
#define open_path_symbol                            0x29DD20 // bytes matched: 0x28  F821FF617C0802A6FB810080FBA10088FBE10098FB410070FB610078F80100B0
#define open_fs_object_symbol                       0x18A6DC // 7D800026F821FF31 FBC100C0EBC2 found by Joonie
#define close_fs_object_symbol                      0x189618 // bytes matched: 0x18****  E80300F82FA000004D9E002038000000E88300F8F80300F8

#define storage_get_device_info_symbol              0x281F58 // bytes matched: 0x34*  7C0802A6F821FF71F80100A0FBE10088F86100C0EBE90000FB810070FBC10080
#define storage_open_symbol                         0x281968 // bytes matched: 0x40*  7C0802A6F821FF11F8010100FBA100D8F8610120EBA90000FB4100C07C9A2378
#define storage_close_symbol                        0x281758 // bytes matched: 0x38*  7C0802A6F821FF51F80100C0FBE100A8FB810090EBE900007C7C1B7838800000
#define storage_read_symbol                         0x280CC8 // bytes matched: 0x54  F821FF017C0802A6FBE100F83BE10070FBA100E8787D00207FE3FB78F8010110
#define storage_send_device_command_symbol          0x280854 // bytes matched: 0x80*  7C0802A6F821FEF1F8010120FBE101087C7F1B78E86B0000FBA100F8FBC10100
#define storage_map_io_memory_symbol                0x281E14 // bytes matched: 0x38*  7C0802A6F821FF61F80100B0FBE10098FB810080EBE900007C9C2378FBC10090
#define storage_unmap_io_memory_symbol              0x281CE0 // bytes matched: 0x38*  7C0802A6F821FF71F80100A0FBE10088FB810070EBE900007C9C2378FBC10080
#define storage_internal_get_device_object_symbol   0x28030C // bytes matched: 0x80  F821FF717C0802A6FBA10078F80100A0E80300007CBD2B78FBC100802FA00000


#define decrypt_func_symbol                         0x34794 // bytes matched: 0x64  F821FF717C0802A6FB810070FBA100787C7C1B787C9D2378F80100A04BFFFF95
#define lv1_call_99_wrapper_symbol                  0x4ECCC // bytes matched: 0x64  F821FF717C0802A6FBA100787C7D1B78FB810070386300807C9C2378F80100A0
#define modules_verification_symbol                 0x58824 // bytes matched: 0x80  3884FFFA7C0802A6F821FF912B840036F8010080419D00FCE962994078891788
//#define authenticate_program_segment_symbol


#define prx_load_module_symbol                      0x87230 // bytes matched: 0x80  F821FF717C0802A6FB8100707CBC2B7838A00001FBA10078FBC10080FBE10088
#define prx_start_module_symbol                     0x85EFC // bytes matched: 0x80  7D800026F821FEF1FB2100D8FB4100E07C7907B47C9A2378FB0100D0FB8100F0
#define prx_stop_module_symbol                      0x872D4 // bytes matched: 0x80  F821FF617C0802A6FBA10088FBC100907C7D1B787C9E2378FB810080F80100B0
#define prx_unload_module_symbol                    0x85C30 // bytes matched: 0x80  F821FF617C0802A6FB810080FBC100907C7C07B47C9E2378FBA10088FBE10098


#define extend_kstack_symbol                        0x6E7C0 // bytes matched: 0x44  F821FF717C0802A6FB810070F80100A0FBA100787C7D1B784BFB7841E922A100

#define get_pseudo_random_number_symbol             0x230930 // bytes matched: 0x40**  7C8523787C04037848000404480001E4F821FF717C0802A6FB810070FBC10080

#define syscall_table_symbol                        0x35F0D0 // Found by Joonie
#define syscall_call_offset                         0x27E05C // bytes matched: 0x34  4E80002138210070F821FFB1F8610008F8810010F8A10018F8C10020F8E10028

#define read_bdvd0_symbol                           0x1AD04C // bytes matched: 0x20  F821FEB17C0802A6FB0101107C781B78F8010160F9C100C0FBC101407C8E2378
#define read_bdvd1_symbol                           0x1AEC78 // bytes matched: 0x80  F821FF317C0802A6FB8100B0F80100E0EB8300207CA02B78FAE100882FBC0000
#define read_bdvd2_symbol                           0x1BBE00 // bytes matched: 0x80  F821FF517C0802A6FBE100A8F80100C07C7F1B78E8630090FB610088FB810090

/* Calls, jumps */
#define device_event_port_send_call                 0x28A4C4 // bytes matched: 0x3C*  F821FF617C0802A6FBC10090F80100B0FBE100987C7E1B78E86300D87C9F2378

//#define ss_pid_call_1

#define process_map_caller_call                     0x4D24 // bytes matched: 0x10*  2F8300007C7D1B78419EFF1C807B0000

#define fsloop_open_call                            0x29E180 // bytes matched: 0x80  4BFFFE697C6307B44BFFFFC08063000880AA00187C6307B4E8CA00207CA507B4
#define fsloop_close_call                           0x29E1D0 // bytes matched: 0x68  4BFFFC817C6307B44BFFFF7080630008E8CA00207C6307B4E88A0010E8AA0018
#define fsloop_read_call                            0x29E210 // bytes matched: 0x28  4BFFFD7D7C6307B44BFFFF30F821FF317C0802A6FB010090FB6100A8FBA100B8

/* Patches */

#define user_thread_prio_patch                      0x20228 // bytes matched: 0x34  419DFF842B9E0BFF900100D0419D02587B8007A03FE080012FA0000363FF0009
#define user_thread_prio_patch2                     0x20234 // bytes matched: 0x28  419D02587B8007A03FE080012FA0000363FF0009419EFF64FB4100B87D3042A6

/* Rtoc entries */

#define io_rtoc_entry_1                             -0x1E8 //Found by Joonie //EB C2 FE 18 E9 7E 80 38  EB C1 FF F0 F9 63 00 00
#define io_sub_rtoc_entry_1                         -0x7EA0 //UNTOUCHED

#define decrypt_rtoc_entry_2                        -0x6688 //Found by Joonie //E86299784BFFC599 392000004BFFFFCC 2C2400007C0802A6 //UNTOUCHED
//#define decrypter_data_entry                      -0x7F10

#define storage_rtoc_entry_1                        0x1DC8 //Found by Joonie // E9621DC87C0802A6 F821FF51F80100C0 FBE100A87C9F2378 7C641B78E86B0000

#define device_event_rtoc_entry_1                   0x2038 //Found by Joonie//E9622038 78050620E8CA0038 7D052B78E92B0000

/* Legacy patches with no names yet */
/* Kernel offsets */

#define patch_func2                                 0x591DC // bytes matched: 0x80  F821FF617C0802A6FBC100907C9E2378E862997038810070FBA10088FBE10098
#define patch_func2_offset                          0x2C //UNTOUCHED


/* vars */
// TODO: #define open_psid_buf_symbol               0x45218C
#define thread_info_symbol                          0x379230 //Found by Joonie


#elif defined(FIRMWARE_4_60)

#define process_rtoc_entry_1				-0x7800 //
#define TOC                                         0x34F950 //done

#define open_shared_kernel_object_symbol            0x1240C // bytes matched: 0x80  F821FF317C0802A6FB8100B0FBC100C0FBE100C8F80100E0789C84027CE03B78
#define close_kernel_object_handle_symbol           0x11A2C // bytes matched: 0x3C  F821FF517C0802A6FBA10098FBE100A8FB410080FB610088FB810090FBC100A0

#define alloc_symbol                                0x64798 // bytes matched: 0x14  2C2300007C85237838C000007C641B784D820020
#define dealloc_symbol                              0x64BD4 // bytes matched: 0x28*  7C85237838C000007C641B78E86900004BFFFBD0F821FF717C0802A6FBA10078
#define copy_to_user_symbol                         0xF868 // bytes matched: 0x60  2C2500007C0802A6F821FF71FBA10078FBC10080FBE100887C7E1B78FB810070
#define copy_from_user_symbol                       0xFA84 // bytes matched: 0x60  2C2500007C0802A6F821FF71FBA10078FBC10080FBE10088FB8100707C7F1B78
#define copy_to_process_symbol                      0xF920 // bytes matched: 0x60  F821FF317C0802A62C250000FB6100A83F608001FB210098FB8100B0FAE10088
#define copy_from_process_symbol                    0xF730 // bytes matched: 0x58  F821FF417C0802A62C240000FB6100983F608001FB210088FB8100A0FB010080
#define page_allocate_symbol                        0x60308 // bytes matched: 0x60  7C8023787CA92B787CCB33787CE83B787C641B787C0503787D264B787D675B78
#define page_free_symbol                            0x5FD6C // bytes matched: 0x5C*  7C0802A6F821FF61F80100B0FBC10090FBE10098E92B00007C7F1B787CBE2B78
#define page_export_to_proc_symbol                  0x604A4 // bytes matched: 0x3C  F821FF717C0802A63D20000CF80100A054A0031AFBE100887FA048003D208001
#define page_unexport_from_proc_symbol              0x5FC60 // bytes matched: 0x20**  2BA3003C7C0802A6F821FF91F80100807C8B23787C601B7841DD0084786326E4
#define kernel_ea_to_lpar_addr_symbol               0x700C0 // bytes matched: 0x80*  7C0802A6F821FF51F80100C0FBC100A0FB610088EBC900007C9B2378FB810090
#define map_process_memory_symbol                   0x771E0 // bytes matched: 0x14  7D800026F821FEE1FAC100D07CF63B78FB810100

#define memcpy_symbol                               0x7E8A0 // bytes matched: 0x80  2BA500077C6B1B78419D002C2C2500007C691B784D8200207CA903A688040000
#define memset_symbol                               0x4D668 // bytes matched: 0x80  2BA500177C6A1B78419D00242FA500004D9E00207C8023787CA903A6980A0000
#define memcmp_symbol                               0x4C978 // bytes matched: 0x80  38A500017CA903A642400030880300003863000189240000388400017F890000

#define sprintf_symbol                              0x4EA90 // bytes matched: 0x80  F821FF817C0802A6F8A100C0F8010090380100C0E8A295A8F8C100C8F8610078
#define snprintf_symbol                             0x4E9FC // bytes matched: 0x80  F821FF717C0802A6F8C100D8F80100A0380100D8F8610078908100807CA32B78
#define strcpy_symbol                               0x4D814 // bytes matched: 0x80  880400002F800000980300004D9E00207C691B788C0400012F8000009C090001
#define strncpy_symbol                              0x4D8DC // bytes matched: 0x80  2C2500004D820020880400007C6B1B78394000002F80000098030000419E0034
#define strlen_symbol                               0x4D83C // bytes matched: 0x80  7C691B7838600000880900002F8000004D9E00207D234B788C0300012F800000
#define strcat_symbol                               0x4D744 // bytes matched: 0x80  880300007C691B782F800000419E00108C0900012F800000409EFFF888040000
#define strcmp_symbol                               0x4D7C0 // bytes matched: 0x80  880300007C691B78896400007F8B00007C0B0050409E002C2F8B0000409E000C
#define strncmp_symbol                              0x4D868 // bytes matched: 0x80  2C2500004182005089640000892300005560063E7F895800409E00482F800000
#define strchr_symbol                               0x4D77C // bytes matched: 0x80  880300002F800000419E00247F802000409E000C48000024419A00208C030001

#define spin_lock_irqsave_ex_symbol                 0x27641C // bytes matched: 0x80  7D0000A6550004202FA00000419E006C380000027C0101643D60ABAD616BCAFE
#define spin_unlock_irqrestore_ex_symbol            0x2763F0 // bytes matched: 0x80  7C2004AC2F850000380000003920000090030000409E000C7C8101644E800020

#define load_process_symbol                         0x5004 // bytes matched: 0x80  7D800026F821FF11FAC100A0FB6100C8FB8100D07C7B1B787CB62B787C9C2378

#define ppu_thread_create_symbol                    0x13EC4 // bytes matched: 0x54  7D800026F821FF81FBC10070FBE100787C7E1B787CDF3378918100887C0802A6
#define ppu_thread_exit_symbol                      0x13F7C // Patched //Old: 0x135D0 // bytes matched: 0x14  F821FF817C0802A6FBE10078F80100907C7F1B78
#define ppu_thread_join_symbol                      0x13FD0 // bytes matched: 0x24  F821FF617C0802A6FB810080F80100B0FBA10088FBC100907C7D1B78FBE10098
#define ppu_thread_delay_symbol                     0x287A0 // bytes matched: 0x44  F821FF017C0802A6FAC100B0FAE100B8FB6100D8FBA100E8FBC100F0FB0100C0

#define create_user_thread2_symbol                  0x2507C // bytes matched: 0x80  F821FEF17C0802A6FA8100B0F8010120800900287CD43378FAA100B8FAC100C0
#define start_thread_symbol                         0x23D48 // bytes matched: 0x80  7D800026F821FF61FB410070FB610078FB810080FBA10088FBC10090FBE10098
#define run_thread_symbol                           0x23578 // bytes matched: 0x30  7C641B78E863004848002EB0F821FF717C0802A6FBC100807C7E1B78FBA10078
#define register_thread_symbol                      0x2705D0 // bytes matched: 0x80  7D800026F821FF712C240000FBC10080FBE10088FBA100787C9F23787C7E1B78
#define allocate_user_stack_symbol                  0x270DB8 // bytes matched: 0x50  F821FF617C0802A6FBA10088F80100B0E803003038C10070FBC100902FA00000

#define mutex_create_symbol                         0x13638 // bytes matched: 0x7C  2F8500207C0802A6F821FF71FBA10078FBC10080FBE10088F80100A07CBF2B78
#define mutex_destroy_symbol                        0x135D0 // bytes matched: 0x14  F821FF817C0802A6FBE10078F80100907C7F1B78
#define mutex_lock_symbol                           0x135C8 // bytes matched: 0x14**  F821FF817C0802A6FBE10078F80100907C7F1B78
#define mutex_unlock_symbol                         0x135C0  //unconfirmed //48009CD44800990C

#define event_port_create_symbol                    0x13074 // bytes matched: 0x2C  F821FF717C0802A6FBA10078FBC1008038A000007C7E1B787C9D237838600020
#define event_port_destroy_symbol                   0x134DC // Patched //Old: 0x13304 // bytes matched: 0x2C  F821FF717C0802A6FBC10080EBC2859038800000F80100A0FBA1007838A00000
#define event_port_connect_symbol                   0x13554 // bytes matched: 0x30  F821FF617C0802A6FB610078EB62859038A00000F80100B0FB810080FBA10088
#define event_port_disconnect_symbol                0x13480 // bytes matched: 0x28  F821FF717C0802A6FB810070EB82859038800000F80100A0FBA1007838A00000
#define event_port_send_symbol                      0x1306C // bytes matched: 0x2C**  F821FF717C0802A6FBA10078FBC1008038A000007C7E1B787C9D237838600020

#define event_queue_create_symbol                   0x1337C // bytes matched: 0x80  F821FF617C0802A6FBE10098F80100B03806FFFF3FE080012B80007E3804FFFF
#define event_queue_destroy_symbol                  0x13304 // bytes matched: 0x2C  F821FF717C0802A6FBC10080EBC2859038800000F80100A0FBA1007838A00000
#define event_queue_receive_symbol                  0x13148 // bytes matched: 0x6C  F821FF617C0802A6FBE10098F80100B0812300883FE08001380000002F890001

#define cellFsOpen_symbol                           0x2A0584 // bytes matched: 0x1C  F821FF517C0802A6FB010070FB610088FBA10098FBC100A07C7D1B78
#define cellFsClose_symbol                          0x2A03EC // bytes matched: 0xC   F821FF61 7C0802A6FBC10090
#define cellFsRead_symbol                           0x2A0528 // bytes matched: 0x34  2C2600007C0802A63D208001F821FF71FBE10080F80100A07CDF33786129000D
#define cellFsWrite_symbol                          0x2A0494 // bytes matched: 0x24****  FB410080FB6100887CDA33787CBB2B78FB810090FBA100987C9C2378F80100C0
#define cellFsLseek_symbol                          0x29FB1C // bytes matched: 0x24****  FB410080FB6100887CDA33787C9B2378FB810090FBA100987CBC2B78F80100C0
#define cellFsStat_symbol                           0x29FDA0 // bytes matched: 0x18  F821FF617C0802A6FB610078FBA10088FBC100907C7D1B78
#define cellFsUnlink_internal_symbol                0x19C4AC // bytes matched: 0x2C  F821FEF17C0802A62C240000FBE101083FE08001FB8100F0FBA100F8FBC10100

#define cellFsUtilMount_symbol                      0x29F8FC // bytes matched: 0x1C  F821FED17C0802A6FBA101183BA10080FAE100E8FBC101207C972378
#define cellFsUtilUmount_symbol                     0x29F8D0 // Patched //Old: 0x29F884 // bytes matched: 0x20**  7C8023787CA62B787C641B787C05037838E00000E93E80B0EBC1FFF0E8690000

#define pathdup_from_user_symbol                    0x1A23A0 // bytes matched: 0x18  F821FF517C0802A6FB210078FB410080FBC100A07C7A1B78
#define open_path_symbol                            0x2A02BC // bytes matched: 0x28  F821FF617C0802A6FB810080FBA10088FBE10098FB410070FB610078F80100B0
#define open_fs_object_symbol                       0x18A7D0 //                      7D800026F821FF31 FBC100C0EBC2FDD0
#define close_fs_object_symbol                      0x18970C // bytes matched: 0x18****  E80300F82FA000004D9E002038000000E88300F8F80300F8

#define storage_get_device_info_symbol              0x282784 // bytes matched: 0x34*  7C0802A6F821FF71F80100A0FBE10088F86100C0EBE90000FB810070FBC10080
#define storage_open_symbol                         0x282194 // bytes matched: 0x40*  7C0802A6F821FF11F8010100FBA100D8F8610120EBA90000FB4100C07C9A2378
#define storage_close_symbol                        0x281F84 // bytes matched: 0x38*  7C0802A6F821FF51F80100C0FBE100A8FB810090EBE900007C7C1B7838800000
#define storage_read_symbol                         0x2814F4 // bytes matched: 0x54  F821FF017C0802A6FBE100F83BE10070FBA100E8787D00207FE3FB78F8010110
#define storage_send_device_command_symbol          0x281080 // bytes matched: 0x80*  7C0802A6F821FEF1F8010120FBE101087C7F1B78E86B0000FBA100F8FBC10100
#define storage_map_io_memory_symbol                0x282640 // bytes matched: 0x38*  7C0802A6F821FF61F80100B0FBE10098FB810080EBE900007C9C2378FBC10090
#define storage_unmap_io_memory_symbol              0x28250C // bytes matched: 0x38*  7C0802A6F821FF71F80100A0FBE10088FB810070EBE900007C9C2378FBC10080
#define storage_internal_get_device_object_symbol   0x280B38 // bytes matched: 0x80  F821FF717C0802A6FBA10078F80100A0E80300007CBD2B78FBC100802FA00000

#define decrypt_func_symbol                         0x3496C // bytes matched: 0x64  F821FF717C0802A6FB810070FBA100787C7C1B787C9D2378F80100A04BFFFF95
#define lv1_call_99_wrapper_symbol                  0x4EEA4 // bytes matched: 0x64  F821FF717C0802A6FBA100787C7D1B78FB810070386300807C9C2378F80100A0
#define modules_verification_symbol                 0x58A48 // bytes matched: 0x18  3884FFFA7C0802A6F821FF912B840036F8010080419D00FC

#define prx_load_module_symbol                      0x88B78 // bytes matched: 0x80  F821FF717C0802A6FB8100707CBC2B7838A00001FBA10078FBC10080FBE10088
#define prx_start_module_symbol                     0x87844 // bytes matched: 0x6C  7D800026F821FEF1FB2100D8FB4100E07C7907B47C9A2378FB0100D0FB8100F0
#define prx_stop_module_symbol                      0x88C1C // bytes matched: 0x3C  F821FF617C0802A6FBA10088FBC100907C7D1B787C9E2378FB810080F80100B0
#define prx_unload_module_symbol                    0x87578 // bytes matched: 0x3C  F821FF617C0802A6FB810080FBC100907C7C07B47C9E2378FBA10088FBE10098

#define extend_kstack_symbol                        0x70018 // bytes matched: 0x18  F821FF717C0802A6FB810070F80100A0FBA100787C7D1B78

#define get_pseudo_random_number_symbol             0x230E74 // bytes matched: 0x40**  7C8523787C04037848000404480001E4F821FF717C0802A6FB810070FBC10080

#define syscall_table_symbol                        0x363A18
#define syscall_call_offset                         0x27E888 // bytes matched: 0x34  4E80002138210070F821FFB1F8610008F8810010F8A10018F8C10020F8E10028

#define read_bdvd0_symbol                           0x1AD310 // bytes matched: 0x20  F821FEB17C0802A6FB0101107C781B78F8010160F9C100C0FBC101407C8E2378
#define read_bdvd1_symbol                           0x1AEF3C // bytes matched: 0x80  F821FF317C0802A6FB8100B0F80100E0EB8300207CA02B78FAE100882FBC0000
#define read_bdvd2_symbol                           0x1BC0F4 // bytes matched: 0x80  F821FF517C0802A6FBE100A8F80100C07C7F1B78E8630090FB610088FB810090

/* Calls, jumps */
#define device_event_port_send_call                 0x28ACF0 // bytes matched: 0x3C*  F821FF617C0802A6FBC10090F80100B0FBE100987C7E1B78E86300D87C9F2378

#define process_map_caller_call                     0x4D24 // bytes matched: 0x10*  2F8300007C7D1B78419EFF1C807B0000

#define fsloop_open_call                            0x2A071C // bytes matched: 0x80  4BFFFE697C6307B44BFFFFC08063000880AA00187C6307B4E8CA00207CA507B4
#define fsloop_close_call                           0x2A076C // bytes matched: 0x68  4BFFFC817C6307B44BFFFF7080630008E8CA00207C6307B4E88A0010E8AA0018
#define fsloop_read_call                            0x2A07AC // bytes matched: 0x28  4BFFFD7D7C6307B44BFFFF30F821FF317C0802A6FB010090FB6100A8FBA100B8

/* Patches */

#define user_thread_prio_patch                      0x203F8 // bytes matched: 0x34  419DFF842B9E0BFF900100D0419D02587B8007A03FE080012FA0000363FF0009
#define user_thread_prio_patch2                     0x20404 // bytes matched: 0x28  419D02587B8007A03FE080012FA0000363FF0009419EFF64FB4100B87D3042A6

/* Rtoc entries */

#define io_rtoc_entry_1                             -0x1F0
#define io_sub_rtoc_entry_1                         -0x7EA0

#define decrypt_rtoc_entry_2                        -0x66A0 //E86299604BFFBCAD 392000004BFFFFCC 2C2400007C0802A6 F821FF71FBC10080

#define storage_rtoc_entry_1                        0x1DD8

#define device_event_rtoc_entry_1                   0x2048

/* Legacy patches with no names yet */
/* Kernel offsets */

#define patch_func2                                 0x59CF8 //unconfirmed //F821FF617C0802A6 FBC100907C9E2378
#define patch_func2_offset                          0x2C


/* vars */
#define thread_info_symbol                          0x37DBB0 //search for offset of "_SYSTEM IDLE 1" on LV2 dump, then substract -0x5C

#elif defined(FIRMWARE_4_66) //Ported by Joonie, Big thanks to @aldostools for his Getsymbol tool :)

#define process_rtoc_entry_1				-0x7800 //
#define TOC                                         0x34F960 //done

#define open_shared_kernel_object_symbol            0x12410 // bytes matched: 0x80  F821FF317C0802A6FB8100B0FBC100C0FBE100C8F80100E0789C84027CE03B78
#define close_kernel_object_handle_symbol           0x11A30 // bytes matched: 0x44  F821FF517C0802A6FBA10098FBE100A8FB410080FB610088FB810090FBC100A0

#define alloc_symbol                                0x6479C // bytes matched: 0x80  2C2300007C85237838C000007C641B784D820020E9229EC8E86900004BFFFEB8
#define dealloc_symbol                              0x64BD8 // bytes matched: 0x80  E9229EC87C85237838C000007C641B78E86900004BFFFBD0F821FF717C0802A6
#define copy_to_user_symbol                         0xF86C // bytes matched: 0x64  2C2500007C0802A6F821FF71FBA10078FBC10080FBE100887C7E1B78FB810070
#define copy_from_user_symbol                       0xFA88 // bytes matched: 0x64  2C2500007C0802A6F821FF71FBA10078FBC10080FBE10088FB8100707C7F1B78
#define copy_to_process_symbol                      0xF924 // bytes matched: 0x80  F821FF317C0802A62C250000FB6100A83F608001FB210098FB8100B0FAE10088
#define copy_from_process_symbol                    0xF734 // bytes matched: 0x80  F821FF417C0802A62C240000FB6100983F608001FB210088FB8100A0FB010080
#define page_allocate_symbol                        0x6030C // bytes matched: 0x60  7C8023787CA92B787CCB33787CE83B787C641B787C0503787D264B787D675B78
#define page_free_symbol                            0x5FD70 // bytes matched: 0x80  E9629C987C0802A6F821FF61F80100B0FBC10090FBE10098E92B00007C7F1B78
#define page_export_to_proc_symbol                  0x604A8 // bytes matched: 0x80  F821FF717C0802A63D20000CF80100A054A0031AFBE100887FA048003D208001
#define page_unexport_from_proc_symbol              0x5FC64 // bytes matched: 0x80  E8630030480110882BA3003C7C0802A6F821FF91F80100807C8B23787C601B78
#define kernel_ea_to_lpar_addr_symbol               0x700C4 // bytes matched: 0x80  E922A1787C0802A6F821FF51F80100C0FBC100A0FB610088EBC900007C9B2378
#define map_process_memory_symbol                   0x771E4 // bytes matched: 0x7C  7D800026F821FEE1FAC100D07CF63B78FB810100EB82A3A8FB0100E07C781B78

#define memcpy_symbol                               0x7E8A4 // bytes matched: 0x80  2BA500077C6B1B78419D002C2C2500007C691B784D8200207CA903A688040000
#define memset_symbol                               0x4D66C // bytes matched: 0x80  2BA500177C6A1B78419D00242FA500004D9E00207C8023787CA903A6980A0000
#define memcmp_symbol                               0x4C97C // bytes matched: 0x80  38A500017CA903A642400030880300003863000189240000388400017F890000

#define sprintf_symbol                              0x4EA94 // bytes matched: 0x80  F821FF817C0802A6F8A100C0F8010090380100C0E8A295A8F8C100C8F8610078
#define snprintf_symbol                             0x4EA00 // bytes matched: 0x80  F821FF717C0802A6F8C100D8F80100A0380100D8F8610078908100807CA32B78
#define strcpy_symbol                               0x4D818 // bytes matched: 0x80  880400002F800000980300004D9E00207C691B788C0400012F8000009C090001
#define strncpy_symbol                              0x4D8E0 // bytes matched: 0x80  2C2500004D820020880400007C6B1B78394000002F80000098030000419E0034
#define strlen_symbol                               0x4D840 // bytes matched: 0x80  7C691B7838600000880900002F8000004D9E00207D234B788C0300012F800000
#define strcat_symbol                               0x4D748 // bytes matched: 0x80  880300007C691B782F800000419E00108C0900012F800000409EFFF888040000
#define strcmp_symbol                               0x4D7C4 // bytes matched: 0x80  880300007C691B78896400007F8B00007C0B0050409E002C2F8B0000409E000C
#define strncmp_symbol                              0x4D86C // bytes matched: 0x80  2C2500004182005089640000892300005560063E7F895800409E00482F800000
#define strchr_symbol                               0x4D780 // bytes matched: 0x80  880300002F800000419E00247F802000409E000C48000024419A00208C030001

#define spin_lock_irqsave_ex_symbol                 0x276428 // bytes matched: 0x80  7D0000A6550004202FA00000419E006C380000027C0101643D60ABAD616BCAFE
#define spin_unlock_irqrestore_ex_symbol            0x2763FC // bytes matched: 0x80  7C2004AC2F850000380000003920000090030000409E000C7C8101644E800020

#define load_process_symbol                         0x5004 // bytes matched: 0x80  7D800026F821FF11FAC100A0FB6100C8FB8100D07C7B1B787CB62B787C9C2378

#define ppu_thread_create_symbol                    0x13EC8 // bytes matched: 0x80  7D800026F821FF81FBC10070FBE100787C7E1B787CDF3378918100887C0802A6
#define ppu_thread_exit_symbol                      0x13F80 // bytes matched: 0x44  F821FF817C0802A6FBE10078F80100907C7F1B78480122598003009054000462
#define ppu_thread_join_symbol                      0x13FD4 // bytes matched: 0x80  F821FF617C0802A6FB810080F80100B0FBA10088FBC100907C7D1B78FBE10098
#define ppu_thread_delay_symbol                     0x287A4 // bytes matched: 0x64  F821FF017C0802A6FAC100B0FAE100B8FB6100D8FBA100E8FBC100F0FB0100C0

#define create_user_thread2_symbol                  0x25080 // bytes matched: 0x80  F821FEF17C0802A6FA8100B0F8010120800900287CD43378FAA100B8FAC100C0
#define start_thread_symbol                         0x23D4C // bytes matched: 0x80  7D800026F821FF61FB410070FB610078FB810080FBA10088FBC10090FBE10098
#define run_thread_symbol                           0x2357C // bytes matched: 0x30  7C641B78E863004848002EB0F821FF717C0802A6FBC100807C7E1B78FBA10078
#define register_thread_symbol                      0x2705DC // bytes matched: 0x80  7D800026F821FF712C240000FBC10080FBE10088FBA100787C9F23787C7E1B78
#define allocate_user_stack_symbol                  0x270DC4 // bytes matched: 0x50  F821FF617C0802A6FBA10088F80100B0E803003038C10070FBC100902FA00000

#define mutex_create_symbol                         0x1363C // bytes matched: 0x80  2F8500207C0802A6F821FF71FBA10078FBC10080FBE10088F80100A07CBF2B78
#define mutex_destroy_symbol                        0x135D4 // bytes matched: 0x80  F821FF817C0802A6FBE10078F80100907C7F1B78480092352FA300003C008001
#define mutex_lock_symbol                           0x135CC // bytes matched: 0x80  38A000004800A58CF821FF817C0802A6FBE10078F80100907C7F1B7848009235
#define mutex_unlock_symbol                         0x135C4 // bytes matched: 0x80  48009CD44800990C38A000004800A58CF821FF817C0802A6FBE10078F8010090

#define event_port_create_symbol                    0x13078 // bytes matched: 0x80  F821FF717C0802A6FBA10078FBC1008038A000007C7E1B787C9D237838600020
#define event_port_destroy_symbol                   0x134E0 // bytes matched: 0x80  F821FF717C0802A6FBC10080EBC2859038800000F80100A0FBA1007838A00000
#define event_port_connect_symbol                   0x13558 // bytes matched: 0x80  F821FF617C0802A6FB610078EB62859038A00000F80100B0FB810080FBA10088
#define event_port_disconnect_symbol                0x13484 // bytes matched: 0x80  F821FF717C0802A6FB810070EB82859038800000F80100A0FBA1007838A00000
#define event_port_send_symbol                      0x13070 // bytes matched: 0x80  38E0000148018190F821FF717C0802A6FBA10078FBC1008038A000007C7E1B78

#define event_queue_create_symbol                   0x13380 // bytes matched: 0x80  F821FF617C0802A6FBE10098F80100B03806FFFF3FE080012B80007E3804FFFF
#define event_queue_destroy_symbol                  0x13308 // bytes matched: 0x80  F821FF717C0802A6FBC10080EBC2859038800000F80100A0FBA1007838A00000
#define event_queue_receive_symbol                  0x1314C // bytes matched: 0x80  F821FF617C0802A6FBE10098F80100B0812300883FE08001380000002F890001

#define cellFsOpen_symbol                           0x2A0590 // bytes matched: 0x54  F821FF517C0802A6FB010070FB610088FBA10098FBC100A07C7D1B78EBC225B0
#define cellFsClose_symbol                          0x2A03F8 // bytes matched: 0x1C  F821FF617C0802A6FBC10090EBC225B0FBA10088F80100B07C7D1B78
#define cellFsRead_symbol                           0x2A0534 // bytes matched: 0x34  2C2600007C0802A63D208001F821FF71FBE10080F80100A07CDF33786129000D
#define cellFsWrite_symbol                          0x2A04A0 // bytes matched: 0x34  F821FF517C0802A6FBC100A0EBC225B0FB410080FB6100887CDA33787CBB2B78
#define cellFsLseek_symbol                          0x29FB28 // bytes matched: 0x34  F821FF517C0802A6FBC100A0EBC225B0FB410080FB6100887CDA33787C9B2378
#define cellFsStat_symbol                           0x29FDAC // bytes matched: 0x38  F821FF617C0802A6FB610078FBA10088FBC100907C7D1B78EBC225B07C9B2378
#define cellFsUnlink_internal_symbol                0x19C4B4 // bytes matched: 0x80  F821FEF17C0802A62C240000FBE101083FE08001FB8100F0FBA100F8FBC10100

#define cellFsUtilMount_symbol                      0x29F908 // bytes matched: 0x80  F821FED17C0802A6FBA101183BA10080FAE100E8FBC101207C972378EBC225B0
#define cellFsUtilUmount_symbol                     0x29F8DC // *Wrong 0x29F890 // bytes matched: 0x28  FBC1FFF0EBC225B07C8023787CA62B787C641B787C05037838E00000E93E80B0
#define cellFsUtilNewfs_symbol                      0x2A1330

#define pathdup_from_user_symbol                    0x1A23A8 // bytes matched: 0x40  F821FF517C0802A6FB210078FB410080FBC100A07C7A1B78EBC2FE107C992378
#define open_path_symbol                            0x2A02C8 // bytes matched: 0x28  F821FF617C0802A6FB810080FBA10088FBE10098FB410070FB610078F80100B0
#define open_fs_object_symbol                       0x18A7D8 // bytes matched: 0x58  7D800026F821FF31FBC100C0EBC2FD98FB010090FB210098FB4100A0FB6100A8
#define close_fs_object_symbol                      0x189714 // bytes matched: 0x80  7C83237838A00000388000004BFDE180E80300F82FA000004D9E002038000000

#define storage_get_device_info_symbol              0x282790 // bytes matched: 0x38  E9221DD87C0802A6F821FF71F80100A0FBE10088F86100C0EBE90000FB810070
#define storage_open_symbol                         0x2821A0 // bytes matched: 0x44  E9221DD87C0802A6F821FF11F8010100FBA100D8F8610120EBA90000FB4100C0
#define storage_close_symbol                        0x281F90 // bytes matched: 0x3C  E9221DD87C0802A6F821FF51F80100C0FBE100A8FB810090EBE900007C7C1B78
#define storage_read_symbol                         0x281500 // bytes matched: 0x80  F821FF017C0802A6FBE100F83BE10070FBA100E8787D00207FE3FB78F8010110
#define storage_send_device_command_symbol          0x28108C // bytes matched: 0x80  E9621DD87C0802A6F821FEF1F8010120FBE101087C7F1B78E86B0000FBA100F8
#define storage_map_io_memory_symbol                0x28264C // bytes matched: 0x3C  E9221DD87C0802A6F821FF61F80100B0FBE10098FB810080EBE900007C9C2378
#define storage_unmap_io_memory_symbol              0x282518 // bytes matched: 0x3C  E9221DD87C0802A6F821FF71F80100A0FBE10088FB810070EBE900007C9C2378
#define storage_internal_get_device_object_symbol   0x280B44 // bytes matched: 0x80  F821FF717C0802A6FBA10078F80100A0E80300007CBD2B78FBC100802FA00000

#define decrypt_func_symbol                         0x34970 // bytes matched: 0x64  F821FF717C0802A6FB810070FBA100787C7C1B787C9D2378F80100A04BFFFF95
#define lv1_call_99_wrapper_symbol                  0x4EEA8 // bytes matched: 0x64  F821FF717C0802A6FBA100787C7D1B78FB810070386300807C9C2378F80100A0
#define modules_verification_symbol                 0x58A4C // bytes matched: 0x80  3884FFFA7C0802A6F821FF912B840036F8010080419D00FCE962991878891788

#define prx_load_module_symbol                      0x88B7C // bytes matched: 0x80  F821FF717C0802A6FB8100707CBC2B7838A00001FBA10078FBC10080FBE10088
#define prx_start_module_symbol                     0x87848 // bytes matched: 0x80  7D800026F821FEF1FB2100D8FB4100E07C7907B47C9A2378FB0100D0FB8100F0
#define prx_stop_module_symbol                      0x88C20 // bytes matched: 0x80  F821FF617C0802A6FBA10088FBC100907C7D1B787C9E2378FB810080F80100B0
#define prx_unload_module_symbol                    0x8757C // bytes matched: 0x80  F821FF617C0802A6FB810080FBC100907C7C07B47C9E2378FBA10088FBE10098

#define extend_kstack_symbol                        0x7001C // bytes matched: 0x44  F821FF717C0802A6FB810070F80100A0FBA100787C7D1B784BFB61B9E922A138

#define get_pseudo_random_number_symbol             0x230E7C // bytes matched: 0x48  7C601B78E86203A87C8523787C04037848000404480001E4F821FF717C0802A6

#define syscall_table_symbol                        0x363A18 //done
#define syscall_call_offset                         0x27E894 // bytes matched: 0x34  4E80002138210070F821FFB1F8610008F8810010F8A10018F8C10020F8E10028

#define read_bdvd0_symbol                           0x1AD318 // bytes matched: 0x80  F821FEB17C0802A6FB0101107C781B78F8010160F9C100C0FBC101407C8E2378
#define read_bdvd1_symbol                           0x1AEF44 // bytes matched: 0x80  F821FF317C0802A6FB8100B0F80100E0EB8300207CA02B78FAE100882FBC0000
#define read_bdvd2_symbol                           0x1BC0FC // bytes matched: 0x80  F821FF517C0802A6FBE100A8F80100C07C7F1B78E8630090FB610088FB810090

/* Calls, jumps */
#define device_event_port_send_call                 0x28ACFC // bytes matched: 0x3C*  F821FF617C0802A6FBC10090F80100B0FBE100987C7E1B78E86300D87C9F2378

#define process_map_caller_call                     0x4D24 // bytes matched: 0x10*  2F8300007C7D1B78419EFF1C807B0000

#define fsloop_open_call                            0x2A0728 // bytes matched: 0x80  4BFFFE697C6307B44BFFFFC08063000880AA00187C6307B4E8CA00207CA507B4
#define fsloop_close_call                           0x2A0778 // bytes matched: 0x80  4BFFFC817C6307B44BFFFF7080630008E8CA00207C6307B4E88A0010E8AA0018
#define fsloop_read_call                            0x2A07B8 // bytes matched: 0x60  4BFFFD7D7C6307B44BFFFF30F821FF317C0802A6FB010090FB6100A8FBA100B8

/* Patches */

#define user_thread_prio_patch                      0x203FC // bytes matched: 0x34  419DFF842B9E0BFF900100D0419D02587B8007A03FE080012FA0000363FF0009
#define user_thread_prio_patch2                     0x20408 // bytes matched: 0x28  419D02587B8007A03FE080012FA0000363FF0009419EFF64FB4100B87D3042A6

/* Rtoc entries */

#define io_rtoc_entry_1                             -0x1F0 //found at 0x19F553 FE10E97E8038EBC1FFF0F9630000
#define io_sub_rtoc_entry_1                         -0x7EA0 //found at 0x1649EF 8160E97E8168EB9E8140EBBE8170

#define decrypt_rtoc_entry_2                        -0x66A0 //found at 0x5982B 99604BFFBCAD392000004BFFFFCC2C2400007C0802A6

#define storage_rtoc_entry_1                        0x1DD8 //found at 0x280C13 1DD87C0802A6F821FF51F80100C0FBE100A87C9F23

#define device_event_rtoc_entry_1                   0x2048 //found at 0x28ACE7 204878050620E8CA00387D052B78E92B0000

/* Legacy patches with no names yet */
/* Kernel offsets */

#define patch_func2                                 0x59CFC // bytes matched: 0x80  F821FF617C0802A6FBC100907C9E2378E862995838810070FBA10088FBE10098
#define patch_func2_offset                          0x2C // bytes matched: 0x80  0000000000000000000000000000000000000000000000000000000000000000


/* vars */
#define thread_info_symbol                          0x37DBB0 // The same as 4.60's ported by Joonie

#elif defined(FIRMWARE_4_46)

#define TOC						0x348DF0

#define create_kernel_object_symbol			0x12014
#define destroy_kernel_object_symbol			0x11978
#define destroy_shared_kernel_object_symbol		0x112EC
#define open_kernel_object_symbol			0x12664
#define open_shared_kernel_object_symbol		0x12474
#define close_kernel_object_handle_symbol		0x11A94

#define alloc_symbol					0x62F78	
#define dealloc_symbol					0x633B4
#define copy_to_user_symbol				0xF85C
#define copy_from_user_symbol				0xFA78
#define copy_to_process_symbol				0xF914
#define copy_from_process_symbol			0xF724
#define page_allocate_symbol				0x5EAE8
#define page_free_symbol				0x5E54C
#define page_export_to_proc_symbol			0x5EC84
#define page_unexport_from_proc_symbol			0x5E440
#define kernel_ea_to_lpar_addr_symbol			0x6E86C
#define process_ea_to_lpar_addr_ex_symbol		0x75E80
#define set_pte_symbol					0x5CAE4
#define map_process_memory_symbol			0x7598C
#define panic_symbol					0x29D730

#define memcpy_symbol					0x7D04C
#define memset_symbol					0x4D494
#define memcmp_symbol					0x4C7A4
#define memchr_symbol					0x4C754
#define printf_symbol					0x2A0800
#define printfnull_symbol				0x2A5270
#define sprintf_symbol					0x4E8BC
#define snprintf_symbol					0x4E828
#define strcpy_symbol					0x4D640
#define strncpy_symbol					0x4D708
#define strlen_symbol					0x4D668
#define strcat_symbol					0x4D570
#define strcmp_symbol					0x4D5EC
#define strncmp_symbol					0x4D694
#define strchr_symbol					0x4D5A8
#define strrchr_symbol					0x4D778

#define spin_lock_irqsave_ex_symbol			0x29D900
#define spin_unlock_irqrestore_ex_symbol		0x29D8D4

#define create_process_common_symbol			0x29B6F8
#define create_process_base_symbol			0x29ADB4
#define load_process_symbol				0x5004
#define process_kill_symbol				0x29B504

#define ppu_thread_create_symbol			0x13F2C
#define ppu_thread_exit_symbol				0x13FE4
#define ppu_thread_join_symbol				0x14038
#define ppu_thread_delay_symbol				0x285CC
#define create_kernel_thread_symbol			0x24950
#define create_user_thread_symbol			0x2508C
#define create_user_thread2_symbol			0x24EB0
#define start_thread_symbol				0x23B7C
#define run_thread_symbol				0x233AC /* temp name */
#define register_thread_symbol				0x297B10
#define allocate_user_stack_symbol			0x2982F8
#define deallocate_user_stack_symbol			0x298260

#define mutex_create_symbol				0x136A0
#define mutex_destroy_symbol				0x13638
#define mutex_lock_symbol				0x13630
#define mutex_lock_ex_symbol				0x1D98C
#define mutex_trylock_symbol				0x1362C
#define mutex_unlock_symbol				0x13628

#define cond_create_symbol				0x1380C
#define cond_destroy_symbol				0x137BC
#define cond_wait_symbol				0x137B4
#define cond_wait_ex_symbol				0x1EF78
#define cond_signal_symbol				0x13790
#define cond_signal_all_symbol				0x1376C

#define semaphore_initialize_symbol			0x30A7C
#define semaphore_wait_ex_symbol			0x30784
#define semaphore_trywait_symbol			0x3036C
#define semaphore_post_ex_symbol			0x304B8

#define event_port_create_symbol			0x130DC
#define event_port_destroy_symbol			0x13544
#define event_port_connect_symbol			0x135BC
#define event_port_disconnect_symbol			0x134E8
#define event_port_send_symbol				0x130D4
#define event_port_send_ex_symbol			0x2B02C

#define event_queue_create_symbol			0x133E4
#define event_queue_destroy_symbol			0x1336C
#define event_queue_receive_symbol			0x131B0
#define event_queue_tryreceive_symbol			0x1327C

#define cellFsOpen_symbol				0x2C4A78
#define cellFsClose_symbol				0x2C48E0
#define cellFsRead_symbol				0x2C4A1C
#define cellFsWrite_symbol				0x2C4988
#define cellFsLseek_symbol				0x2C4010
#define cellFsStat_symbol				0x2C4294
#define cellFsUtime_symbol				0x2C5CB0
#define cellFsUnlink_internal_symbol			0x1AAF70

#define cellFsUtilMount_symbol				0x2C3DF0
#define cellFsUtilUmount_symbol				0x2C3DC4
#define cellFsUtilNewfs_symbol				0x2C5748

#define pathdup_from_user_symbol			0x1B1000
#define	open_path_symbol				0x2C47B0
#define open_fs_object_symbol				0x190420
#define close_fs_object_symbol				0x18F41C

#define storage_get_device_info_symbol			0x2A9C50
#define storage_get_device_config_symbol		0x2A90E0
#define storage_open_symbol				0x2A9660
#define storage_close_symbol				0x2A9450
#define storage_read_symbol				0x2A89C0
#define storage_write_symbol				0x2A8890
#define storage_send_device_command_symbol		0x2A854C
#define storage_map_io_memory_symbol			0x2A9B0C
#define storage_unmap_io_memory_symbol			0x2A99D8
#define new_medium_listener_object_symbol		0x95AF4
#define delete_medium_listener_object_symbol		0x9732C
#define set_medium_event_callbacks_symbol		0x97690

#define cellUsbdRegisterLdd_symbol			0x290444
#define cellUsbdUnregisterLdd_symbol			0x2903F4
#define cellUsbdScanStaticDescriptor_symbol		0x291644
#define cellUsbdOpenPipe_symbol				0x2916F4
#define cellUsbdClosePipe_symbol			0x2916A4
#define cellUsbdControlTransfer_symbol			0x2915A8
#define cellUsbdBulkTransfer_symbol			0x291528

#define decrypt_func_symbol				0x34798
#define lv1_call_99_wrapper_symbol			0x4ECD0
#define modules_verification_symbol			0x58828
#define authenticate_program_segment_symbol		0x59C64

#define prx_load_module_symbol				0x87234
#define prx_start_module_symbol				0x85F00
#define prx_stop_module_symbol				0x872D8
#define prx_unload_module_symbol			0x85C34
#define prx_get_module_info_symbol			0x856BC
#define prx_get_module_id_by_address_symbol		0x855CC
#define prx_get_module_id_by_name_symbol		0x8561C
#define prx_get_module_list_symbol			0x8573C
#define load_module_by_fd_symbol			0x86864
#define parse_sprx_symbol				0x845E8
#define open_prx_object_symbol				0x7DC08
#define close_prx_object_symbol				0x7E518
#define lock_prx_mutex_symbol				0x85574
#define unlock_prx_mutex_symbol				0x85580

#define extend_kstack_symbol				0x6E7C4

#define get_pseudo_random_number_symbol			0x2587A0
#define md5_reset_symbol				0x162DB0
#define md5_update_symbol				0x163850
#define md5_final_symbol				0x1639D0
#define ss_get_open_psid_symbol				0x25AB68
#define update_mgr_read_eeprom_symbol			0x2542AC
#define update_mgr_write_eeprom_symbol			0x2541F4

#define ss_params_get_update_status_symbol		0x508DC		

#define syscall_table_symbol				0x35E860
#define syscall_call_offset				0x2A5D54

#define read_bdvd0_symbol				0x1BBF70
#define read_bdvd1_symbol				0x1BDB9C
#define read_bdvd2_symbol				0x1CAD54

#define storage_internal_get_device_object_symbol	0x2A8004

#define hid_mgr_read_usb_symbol				0x1037EC
#define hid_mgr_read_bt_symbol				0xFD6C4

#define bt_set_controller_info_internal_symbol		0xF1730 /* just a name... */

/* Calls, jumps */
#define device_event_port_send_call			0x2B2184

#define ss_pid_call_1					0x243AD0

#define process_map_caller_call				0x4D24

#define read_module_header_call				0x7DAFC
#define read_module_body_call				0x671C
#define load_module_by_fd_call1				0x870D0

#define shutdown_copy_params_call			0xAABC

#define fsloop_open_call				0x2C4C10
#define fsloop_close_call				0x2C4C60
#define fsloop_read_call				0x2C4CA0

/* Patches */
#define shutdown_patch_offset				0xAAA8
#define module_sdk_version_patch_offset			0x297340
#define module_add_parameter_to_parse_sprxpatch_offset	0x86940		

#define user_thread_prio_patch				0x2022C
#define user_thread_prio_patch2				0x20238

/* Rtoc entries */

#define io_rtoc_entry_1					-0x150
#define io_sub_rtoc_entry_1				-0x7EA0

#define decrypt_rtoc_entry_2 				-0x6688
#define decrypter_data_entry				-0x7F10

#define storage_rtoc_entry_1				0x1E98

#define device_event_rtoc_entry_1			0x2108

#define time_rtoc_entry_1				-0x7640
#define time_rtoc_entry_2				-0x7648

#define thread_rtoc_entry_1				-0x76C0

#define process_rtoc_entry_1				-0x7800

#define bt_rtoc_entry_1					-0x35D8

/* Permissions */
#define permissions_func_symbol				0x3560  /* before it was patch_func5+patch_func5_offset */
#define permissions_exception1 				0x24F30 /* before it was patch_func6+patch6_func6_offset */
#define permissions_exception2				0xC3554	/* before it was patch_func7+patch7_func7_offset */	
#define permissions_exception3				0x20300 /* Added in v 3.0 */

/* Legacy patches with no names yet */
/* Kernel offsets */
#define patch_data1_offset				0x3DBE40
#define patch_func2 					0x591E0
#define patch_func2_offset 				0x2C
#define patch_func8 					0x55F40 //lv2open update patch
#define patch_func8_offset1 				0xA4 //lv2open update patch
#define patch_func8_offset2 				0x208 //lv2open update patch
#define patch_func9 					0x5969C // must upgrade error
#define patch_func9_offset 				0x470
#define mem_base2					0x3D90

/* vars */
// TODO: #define open_psid_buf_symbol			0x45218C
#define thread_info_symbol				0x376E30


#elif defined(FIRMWARE_4_53)

#define TOC						0x34B2E0 //

#define create_kernel_object_symbol			0x12014 //
#define destroy_kernel_object_symbol			0x11978 //
#define destroy_shared_kernel_object_symbol		0x112EC //
#define open_kernel_object_symbol			0x12664 //
#define open_shared_kernel_object_symbol		0x12474 //
#define close_kernel_object_handle_symbol		0x11A94 //

#define alloc_symbol					0x62F78	 //
#define dealloc_symbol					0x633B4 //
#define copy_to_user_symbol				0xF85C //
#define copy_from_user_symbol				0xFA78 //
#define copy_to_process_symbol				0xF914 //
#define copy_from_process_symbol			0xF724 //
#define page_allocate_symbol				0x5EAE8 //
#define page_free_symbol				0x5E54C //
#define page_export_to_proc_symbol			0x5EC84 //
#define page_unexport_from_proc_symbol			0x5E440 //
#define kernel_ea_to_lpar_addr_symbol			0x6E86C //
#define process_ea_to_lpar_addr_ex_symbol		0x75E80 //
#define set_pte_symbol					0x5CAE4 //
#define map_process_memory_symbol			0x7598C //
#define panic_symbol					0x275C10 //

#define memcpy_symbol					0x7D04C //
#define memset_symbol					0x4D494 //
#define memcmp_symbol					0x4C7A4 //
#define memchr_symbol					0x4C754 //
#define printf_symbol					0x278CE0 //
#define printfnull_symbol				0x27D750 //
#define sprintf_symbol					0x4E8BC //
#define snprintf_symbol					0x4E828 //
#define strcpy_symbol					0x4D640 //
#define strncpy_symbol					0x4D708 //
#define strlen_symbol					0x4D668 //
#define strcat_symbol					0x4D570 //
#define strcmp_symbol					0x4D5EC //
#define strncmp_symbol					0x4D694 //
#define strchr_symbol					0x4D5A8 //
#define strrchr_symbol					0x4D778 //

#define spin_lock_irqsave_ex_symbol			0x275DE0 //
#define spin_unlock_irqrestore_ex_symbol		0x275DB4 //

#define create_process_common_symbol			0x273BD8 //
#define create_process_base_symbol			0x273294 //
#define load_process_symbol				0x5004 //
#define process_kill_symbol				0x2739E4 //

#define ppu_thread_create_symbol			0x13F2C //
#define ppu_thread_exit_symbol				0x13FE4 //
#define ppu_thread_join_symbol				0x14038 //
#define ppu_thread_delay_symbol				0x285CC //
#define create_kernel_thread_symbol			0x24950 //
#define create_user_thread_symbol			0x2508C //
#define create_user_thread2_symbol			0x24EB0 //
#define start_thread_symbol				0x23B7C //
#define run_thread_symbol				0x233AC // /* temp name */
#define register_thread_symbol				0x26FFF0 //
#define allocate_user_stack_symbol			0x2707D8 //
#define deallocate_user_stack_symbol			0x270740 //

#define mutex_create_symbol				0x136A0 //
#define mutex_destroy_symbol				0x13638 //
#define mutex_lock_symbol				0x13630 //
#define mutex_lock_ex_symbol				0x1D98C //
#define mutex_trylock_symbol				0x1362C //
#define mutex_unlock_symbol				0x13628 //

#define cond_create_symbol				0x1380C // 
#define cond_destroy_symbol				0x137BC //
#define cond_wait_symbol				0x137B4 //
#define cond_wait_ex_symbol				0x1EF78 //
#define cond_signal_symbol				0x13790 //
#define cond_signal_all_symbol				0x1376C //

#define semaphore_initialize_symbol			0x30A7C //
#define semaphore_wait_ex_symbol			0x30784 //
#define semaphore_trywait_symbol			0x3036C //
#define semaphore_post_ex_symbol			0x304B8 //

#define event_port_create_symbol			0x130DC //
#define event_port_destroy_symbol			0x13544 //
#define event_port_connect_symbol			0x135BC //
#define event_port_disconnect_symbol			0x134E8 //
#define event_port_send_symbol				0x130D4 //
#define event_port_send_ex_symbol			0x2B02C //

#define event_queue_create_symbol			0x133E4 //
#define event_queue_destroy_symbol			0x1336C //
#define event_queue_receive_symbol			0x131B0 //
#define event_queue_tryreceive_symbol			0x1327C //

#define cellFsOpen_symbol				0x29E1C0 //
#define cellFsClose_symbol				0x29E028 //
#define cellFsRead_symbol				0x29E164 //
#define cellFsWrite_symbol				0x29E0D0 //
#define cellFsLseek_symbol				0x29D758 //
#define cellFsStat_symbol				0x29D9DC //
#define cellFsUtime_symbol				0x29F4C8 //
#define cellFsUnlink_internal_symbol			0x19C14C //FIXED 12/14/13

#define cellFsUtilMount_symbol				0x29D538 //
#define cellFsUtilUmount_symbol				0x29D50C //
#define cellFsUtilNewfs_symbol				0x29EF60 //FIXED!

#define pathdup_from_user_symbol			0x1A2244 //fixed
#define	open_path_symbol				0x29DEF8 //
#define open_fs_object_symbol				0x18A6F0 //
#define close_fs_object_symbol				0x18962C //

#define storage_get_device_info_symbol			0x282130 //
#define storage_get_device_config_symbol		0x2815C0 //
#define storage_open_symbol				0x281B40 //
#define storage_close_symbol				0x281930 //
#define storage_read_symbol				0x280EA0 //
#define storage_write_symbol				0x280D70 //
#define storage_send_device_command_symbol		0x280A2C //
#define storage_map_io_memory_symbol			0x281FEC //
#define storage_unmap_io_memory_symbol			0x281EB8 //
#define new_medium_listener_object_symbol		0x95AF4 //
#define delete_medium_listener_object_symbol		0x9732C //
#define set_medium_event_callbacks_symbol		0x97690 //

#define cellUsbdRegisterLdd_symbol			0x268924 //
#define cellUsbdUnregisterLdd_symbol			0x2688D4 //
#define cellUsbdScanStaticDescriptor_symbol		0x269B24 //
#define cellUsbdOpenPipe_symbol				0x269BD4 //
#define cellUsbdClosePipe_symbol			0x269B84 //
#define cellUsbdControlTransfer_symbol			0x269A88 //
#define cellUsbdBulkTransfer_symbol			0x269A08 //

#define decrypt_func_symbol				0x34798 //
#define lv1_call_99_wrapper_symbol			0x4ECD0 //
#define modules_verification_symbol			0x58828 //
#define authenticate_program_segment_symbol		0x59C64 //

#define prx_load_module_symbol				0x87234 //
#define prx_start_module_symbol				0x85F00 //
#define prx_stop_module_symbol				0x872D8 //
#define prx_unload_module_symbol			0x85C34 //
#define prx_get_module_info_symbol			0x856BC //
#define prx_get_module_id_by_address_symbol		0x855CC //
#define prx_get_module_id_by_name_symbol		0x8561C //
#define prx_get_module_list_symbol			0x8573C //
#define load_module_by_fd_symbol			0x86864 //
#define parse_sprx_symbol				0x845E8 //
#define open_prx_object_symbol				0x7DC08 //
#define close_prx_object_symbol				0x7E518 //
#define lock_prx_mutex_symbol				0x85574 //
#define unlock_prx_mutex_symbol				0x85580 //

#define extend_kstack_symbol				0x6E7C4 //

#define get_pseudo_random_number_symbol			0x230B04 //
#define md5_reset_symbol				0x161BA0 //
#define md5_update_symbol				0x162640 //
#define md5_final_symbol				0x1627C0 //
#define ss_get_open_psid_symbol				0x232FAC //
#define update_mgr_read_eeprom_symbol			0x22C610 //
#define update_mgr_write_eeprom_symbol			0x22C558 //

#define ss_params_get_update_status_symbol		0x508DC //		

#define syscall_table_symbol				0x35F300 //
#define syscall_call_offset				0x27E234 //

#define read_bdvd0_symbol				0x1AD1B4 //
#define read_bdvd1_symbol				0x1AEDE0 //
#define read_bdvd2_symbol				0x1BBF98 //

#define storage_internal_get_device_object_symbol	0x2804E4 //

#define hid_mgr_read_usb_symbol				0x102490 //
#define hid_mgr_read_bt_symbol				0xFC368 //FIXED 12/27/13

#define bt_set_controller_info_internal_symbol		0xF03D4 //FIXED 12/27/13 /* just a name... */

/* Calls, jumps */
#define device_event_port_send_call			0x28A69C //FIXED 12/12/13

#define ss_pid_call_1					0x21BE34 //

#define process_map_caller_call				0x4D24 //

#define read_module_header_call				0x7DAFC //
#define read_module_body_call				0x671C //
#define load_module_by_fd_call1				0x870D0 //

#define shutdown_copy_params_call			0xAABC //

#define fsloop_open_call				0x29E358 //
#define fsloop_close_call				0x29E3A8 //
#define fsloop_read_call				0x29E3E8 //

/* Patches */
#define shutdown_patch_offset				0xAAA8 //
#define module_sdk_version_patch_offset			0x26F820 //
#define module_add_parameter_to_parse_sprxpatch_offset	0x86940	//	

#define user_thread_prio_patch				0x2022C //
#define user_thread_prio_patch2				0x20238 //

/* Rtoc entries */ //MAYBE DONE

#define io_rtoc_entry_1					-0x1E8 //1e8
#define io_sub_rtoc_entry_1				-0x7EA0 //

#define decrypt_rtoc_entry_2 				-0x6688 //
#define decrypter_data_entry				-0x7F10 //

#define storage_rtoc_entry_1				0x1DC8 //

#define device_event_rtoc_entry_1			0x2038 //

#define time_rtoc_entry_1				-0x7640 //
#define time_rtoc_entry_2				-0x7648 //

#define thread_rtoc_entry_1				-0x76C0 //

#define process_rtoc_entry_1				-0x7800 //

#define bt_rtoc_entry_1					-0x3670 //

/* Permissions */
#define permissions_func_symbol				0x3560 // /* before it was patch_func5+patch_func5_offset */
#define permissions_exception1 				0x24F30 // /* before it was patch_func6+patch6_func6_offset */
#define permissions_exception2				0xC3574	//FIXED 12/28/13 /* before it was patch_func7+patch7_func7_offset */	
#define permissions_exception3				0x20300 // /* Added in v 3.0 */

/* Legacy patches with no names yet */
/* Kernel offsets */
#define patch_data1_offset				0x3DE440 //
#define patch_func2 					0x591E0 //
#define patch_func2_offset 				0x2C //
#define patch_func8 					0x55F40 // //lv2open update patch
#define patch_func8_offset1 				0xA4 // //lv2open update patch
#define patch_func8_offset2 				0x208 // //lv2open update patch
#define patch_func9 					0x5969C // // must upgrade error
#define patch_func9_offset 				0x470 //
#define mem_base2					0x3D90 //

/* vars */
// TODO: #define open_psid_buf_symbol			0x45218C
#define thread_info_symbol				0x379430 //

#elif defined(FIRMWARE_4_55) 

#define TOC						0x34E620 //

#define create_kernel_object_symbol			0x12024 //
#define destroy_kernel_object_symbol			0x11988 //
#define destroy_shared_kernel_object_symbol		0x112FC //
#define open_kernel_object_symbol			0x12674 //
#define open_shared_kernel_object_symbol		0x12484 //
#define close_kernel_object_handle_symbol		0x11AA4 //CHECKED TILL HERE!!

#define alloc_symbol					0x643B4 //	
#define dealloc_symbol					0x647F0 //
#define copy_to_user_symbol				0xF86C //
#define copy_from_user_symbol				0xFA88 //
#define copy_to_process_symbol				0xF924 //
#define copy_from_process_symbol			0xF734 //
#define page_allocate_symbol				0x5FF24 // 0X143C+
#define page_free_symbol				0x5F988 //
#define page_export_to_proc_symbol			0x600C0 //
#define page_unexport_from_proc_symbol			0x5F87C //
#define kernel_ea_to_lpar_addr_symbol			0x6FCA8 //
#define process_ea_to_lpar_addr_ex_symbol		0x772BC //
#define set_pte_symbol					0x5DF20 //
#define map_process_memory_symbol			0x76DC8 //
#define panic_symbol					0x277460 //

#define memcpy_symbol					0x7E488 //
#define memset_symbol					0x4D6D8 // FIXED!!
#define memcmp_symbol					0x4C9E8 //
#define memchr_symbol					0x4C998 //
#define printf_symbol					0x27A530 //
#define printfnull_symbol				0x27EFA0 //
#define sprintf_symbol					0x4EB00 //
#define snprintf_symbol					0x4EA6C //
#define strcpy_symbol					0x4D884 //
#define strncpy_symbol					0x4D94C //
#define strlen_symbol					0x4D8AC //
#define strcat_symbol					0x4D7B4 //
#define strcmp_symbol					0x4D830 //
#define strncmp_symbol					0x4D8D8 //
#define strchr_symbol					0x4D7EC //
#define strrchr_symbol					0x4D9BC //CHECKED TILL HERE!

#define spin_lock_irqsave_ex_symbol			0x277630 //
#define spin_unlock_irqrestore_ex_symbol		0x277604 //

#define create_process_common_symbol			0x275430 //
#define create_process_base_symbol			0x274AE0 //
#define load_process_symbol				0x5004 //
#define process_kill_symbol				0x27523C //CHECKED TILL HERE!REALLY/2/18/14!

#define ppu_thread_create_symbol			0x13F3C //
#define ppu_thread_exit_symbol				0x13FF4 //
#define ppu_thread_join_symbol				0x14048 //
#define ppu_thread_delay_symbol				0x28810 //
#define create_kernel_thread_symbol			0x24B94 //
#define create_user_thread_symbol			0x252D0 //
#define create_user_thread2_symbol			0x250F4 //
#define start_thread_symbol				0x23DC0 //
#define run_thread_symbol				0x235F0 // /* temp name */
#define register_thread_symbol				0x27183C //
#define allocate_user_stack_symbol			0x272024 //
#define deallocate_user_stack_symbol			0x271F8C //CHECKED TILL HERE!REALLY2!

#define mutex_create_symbol				0x136B0 //
#define mutex_destroy_symbol				0x13648 //
#define mutex_lock_symbol				0x13640 //
#define mutex_lock_ex_symbol				0x1DBD0 //
#define mutex_trylock_symbol				0x1363C //
#define mutex_unlock_symbol				0x13638 //

#define cond_create_symbol				0x1381C //
#define cond_destroy_symbol				0x137CC //
#define cond_wait_symbol				0x137C4 //
#define cond_wait_ex_symbol				0x1F1BC //
#define cond_signal_symbol				0x137A0 //
#define cond_signal_all_symbol				0x1377C //CHECKED TILL HERE!

#define semaphore_initialize_symbol			0x30CC0 //
#define semaphore_wait_ex_symbol			0x309C8 //
#define semaphore_trywait_symbol			0x305B0 //
#define semaphore_post_ex_symbol			0x306FC //

#define event_port_create_symbol			0x130EC //
#define event_port_destroy_symbol			0x13554 //
#define event_port_connect_symbol			0x135CC //
#define event_port_disconnect_symbol			0x134F8 //
#define event_port_send_symbol				0x130E4 //
#define event_port_send_ex_symbol			0x2B270 //

#define event_queue_create_symbol			0x133F4 //
#define event_queue_destroy_symbol			0x1337C //
#define event_queue_receive_symbol			0x131C0 //
#define event_queue_tryreceive_symbol			0x1328C //CHECKED TILL HERE!

#define cellFsOpen_symbol				0x29FA10 //
#define cellFsClose_symbol				0x29F878 //
#define cellFsRead_symbol				0x29F9B4 //
#define cellFsWrite_symbol				0x29F920 //
#define cellFsLseek_symbol				0x29EFA8 //
#define cellFsStat_symbol				0x29F22C //
#define cellFsUtime_symbol				0x2A0D18 //FIXED AGAIN!!
#define cellFsUnlink_internal_symbol			0x19D638 //FIXED UP!+CHECKED TILL HERE!

#define cellFsUtilMount_symbol				0x29ED88 //
#define cellFsUtilUmount_symbol				0x29ED5C //
#define cellFsUtilNewfs_symbol				0x2A07B0 //

#define pathdup_from_user_symbol			0x1A3730 //
#define	open_path_symbol				0x29F748 //
#define open_fs_object_symbol				0x18BB60 //
#define close_fs_object_symbol				0x18AA9C //

#define storage_get_device_info_symbol			0x283980 //
#define storage_get_device_config_symbol		0x282E10 //
#define storage_open_symbol				0x283390 //
#define storage_close_symbol				0x283180 //
#define storage_read_symbol				0x2826F0 //
#define storage_write_symbol				0x2825C0 //CHECKED TILL HERE!2/19/14
#define storage_send_device_command_symbol		0x28227C //
#define storage_map_io_memory_symbol			0x28383C //
#define storage_unmap_io_memory_symbol			0x283708 //
#define new_medium_listener_object_symbol		0x96F40 //
#define delete_medium_listener_object_symbol		0x98778 //
#define set_medium_event_callbacks_symbol		0x98ADC //CHECKED TILL HERE!!

#define cellUsbdRegisterLdd_symbol			0x26A16C //FIXED!
#define cellUsbdUnregisterLdd_symbol			0x26A11C //
#define cellUsbdScanStaticDescriptor_symbol		0x26B36C //
#define cellUsbdOpenPipe_symbol				0x26B41C //
#define cellUsbdClosePipe_symbol			0x26B3CC //
#define cellUsbdControlTransfer_symbol			0x26B2D0 //
#define cellUsbdBulkTransfer_symbol			0x26B250 //CHECKED TILL HERE!

#define decrypt_func_symbol				0x349DC //
#define lv1_call_99_wrapper_symbol			0x4EF14 //
#define modules_verification_symbol			0x586E8 //SUSPICIOUS! BUT NOW LOOKS LIKE FINE!
#define authenticate_program_segment_symbol		0x5A51C //CHECKED TILL HERE!!

#define prx_load_module_symbol				0x88680 //
#define prx_start_module_symbol				0x8734C //
#define prx_stop_module_symbol				0x88724 //
#define prx_unload_module_symbol			0x87080 //
#define prx_get_module_info_symbol			0x86B08 //
#define prx_get_module_id_by_address_symbol		0x86A18 //
#define prx_get_module_id_by_name_symbol		0x86AB8 //
#define prx_get_module_list_symbol			0x86B88 //
#define load_module_by_fd_symbol			0x87CB0 //
#define parse_sprx_symbol				0x85A34 //
#define open_prx_object_symbol				0x7F054 //
#define close_prx_object_symbol				0x7F964 //
#define lock_prx_mutex_symbol				0x869C0 //
#define unlock_prx_mutex_symbol				0x869CC //CHECKED TILL HERE!

#define extend_kstack_symbol				0x6FC00 //

#define get_pseudo_random_number_symbol			0x2321D4 //
#define md5_reset_symbol				0x163004 //
#define md5_update_symbol				0x163AA4 //
#define md5_final_symbol				0x163C24 //
#define ss_get_open_psid_symbol				0x2346BC //
#define update_mgr_read_eeprom_symbol			0x22DACC //
#define update_mgr_write_eeprom_symbol			0x22DA14 //

#define ss_params_get_update_status_symbol		0x50B20 //		

#define syscall_table_symbol				0x362680 //
#define syscall_call_offset				0x27FA84 //

#define read_bdvd0_symbol				0x1AE6A0 //FIXED!!
#define read_bdvd1_symbol				0x1B02CC //
#define read_bdvd2_symbol				0x1BD454 //CHECKED TILL HERE!!

#define storage_internal_get_device_object_symbol	0x281D34 //CHECKED!!

#define hid_mgr_read_usb_symbol				0x1038F4 //
#define hid_mgr_read_bt_symbol				0xFD7CC //CHECKED TILL HERE!

#define bt_set_controller_info_internal_symbol		0xF1838 // /* just a name... */

/* Calls, jumps */
#define device_event_port_send_call			0x28BEEC //

#define ss_pid_call_1					0x21D2F0 //

#define process_map_caller_call				0x4D24 //

#define read_module_header_call				0x7EF48 //
#define read_module_body_call				0x671C //
#define load_module_by_fd_call1				0x8851C //CHECKED TILL HERE!

#define shutdown_copy_params_call			0xAACC //

#define fsloop_open_call				0x29FBA8 //
#define fsloop_close_call				0x29FBF8 //
#define fsloop_read_call				0x29FC38 //CHECKED TILL HERE!

/* Patches */
#define shutdown_patch_offset				0xAAB8 //
#define module_sdk_version_patch_offset			0x27106C //
#define module_add_parameter_to_parse_sprxpatch_offset	0x87D8C //		

#define user_thread_prio_patch				0x20470 //
#define user_thread_prio_patch2				0x2047C //CHECKED TILL HERE!

/* Rtoc entries || CHECKED!!*/

#define io_rtoc_entry_1					-0x1B8 //
#define io_sub_rtoc_entry_1				-0x7EA0 //

#define decrypt_rtoc_entry_2 				-0x66A8 //
#define decrypter_data_entry				-0x7F10 //

#define storage_rtoc_entry_1				0x1E10 //

#define device_event_rtoc_entry_1			0x2080 //

#define time_rtoc_entry_1				-0x7640 //
#define time_rtoc_entry_2				-0x7648 //

#define thread_rtoc_entry_1				-0x76C0 //

#define process_rtoc_entry_1				-0x7800 //

#define bt_rtoc_entry_1					-0x3640 //

/* Permissions */
#define permissions_func_symbol				0x3560 //  /* before it was patch_func5+patch_func5_offset */
#define permissions_exception1 				0x25174 // /* before it was patch_func6+patch6_func6_offset */
#define permissions_exception2				0xC49D8 //	/* before it was patch_func7+patch7_func7_offset */	
#define permissions_exception3				0x20544 //CHECKED TILL HERE! /* Added in v 3.0 */

/* Legacy patches with no names yet */
/* Kernel offsets */
#define patch_data1_offset				0x3E17C0 //
#define patch_func2 					0x59990 //
#define patch_func2_offset 				0x2C //
#define patch_func8 					0x56200 // //lv2open update patch
#define patch_func8_offset1 				0xA4 // //lv2open update patch
#define patch_func8_offset2 				0x208 // //lv2open update patch
#define patch_func9 					0x59E4C // // must upgrade error
#define patch_func9_offset 				0x4B8 //FIXED!!
#define mem_base2					0x3D90 //CHECKED KERNEL OFFSETS!

/* vars */
// TODO: #define open_psid_buf_symbol			0x45218C
#define thread_info_symbol				0x37C7B0 //

#elif defined(FIRMWARE_4_50DEX)

#define TOC						0x36EC40 //done

#define create_kernel_object_symbol			0x12658 //done
#define destroy_kernel_object_symbol			0x11FBC //done
#define destroy_shared_kernel_object_symbol		0x11930 //done
#define open_kernel_object_symbol			0x12CA8 //done
#define open_shared_kernel_object_symbol		0x12AB8 //done
#define close_kernel_object_handle_symbol		0x120D8 //done

#define alloc_symbol					0x66944 //done	
#define dealloc_symbol					0x66D80 //done
#define copy_to_user_symbol				0xFEA0 //done
#define copy_from_user_symbol				0x100BC //done
#define copy_to_process_symbol				0xFF58 //done
#define copy_from_process_symbol			0xFD68 //done
#define page_allocate_symbol				0x624B4 //done
#define page_free_symbol				0x61F18 //done
#define page_export_to_proc_symbol			0x62650 //done
#define page_unexport_from_proc_symbol			0x61E0C //done
#define kernel_ea_to_lpar_addr_symbol			0x723B8 //done
#define process_ea_to_lpar_addr_ex_symbol		0x79F58 //done
#define set_pte_symbol					0x604B0 //done
#define map_process_memory_symbol			0x79A64 //done
#define panic_symbol					0x27D944 //done

#define memcpy_symbol					0x81124 //done
#define memset_symbol					0x50E38 //done
#define memcmp_symbol					0x50148 //done
#define memchr_symbol					0x500F8 //done
#define printf_symbol					0x280E08 //done
#define printfnull_symbol				0x28588C //done
#define sprintf_symbol					0x52260 //done
#define snprintf_symbol					0x521CC //done
#define strcpy_symbol					0x50FE4 //done
#define strncpy_symbol					0x510AC //done
#define strlen_symbol					0x5100C //done
#define strcat_symbol					0x50F14 //done
#define strcmp_symbol					0x50F90 //done
#define strncmp_symbol					0x51038 //done
#define strchr_symbol					0x50F4C //done
#define strrchr_symbol					0x5111C //done

#define spin_lock_irqsave_ex_symbol			0x27DB14 //done
#define spin_unlock_irqrestore_ex_symbol		0x27DAE8 //done

#define create_process_common_symbol			0x27A928 //done
#define create_process_base_symbol			0x279FCC //done
#define load_process_symbol				0x5004 //done
#define process_kill_symbol				0x27A728 //done

#define ppu_thread_create_symbol			0x1465C //done
#define ppu_thread_exit_symbol				0x14714 //done
#define ppu_thread_join_symbol				0x14768 //done
#define ppu_thread_delay_symbol				0x2A50C //done
#define create_kernel_thread_symbol			0x265FC //done
#define create_user_thread_symbol			0x26D38 //done
#define create_user_thread2_symbol			0x26B5C //done
#define start_thread_symbol				0x25694 //done
#define run_thread_symbol				0x24E58 /* temp name */ //done
#define register_thread_symbol				0x27673C //done
#define allocate_user_stack_symbol			0x276F24 //done
#define deallocate_user_stack_symbol			0x276E8C //done

#define mutex_create_symbol				0x13CEC //done
#define mutex_destroy_symbol				0x13C84 //done
#define mutex_lock_symbol				0x13C7C //done
#define mutex_lock_ex_symbol				0x1F438 //done
#define mutex_trylock_symbol				0x13C78 //done
#define mutex_unlock_symbol				0x13C74 //done

#define cond_create_symbol				0x13E58 //done
#define cond_destroy_symbol				0x13E08 //done
#define cond_wait_symbol				0x13E00 //done
#define cond_wait_ex_symbol				0x20A24 //done
#define cond_signal_symbol				0x13DDC //done
#define cond_signal_all_symbol				0x13DB8 //done

#define semaphore_initialize_symbol			0x34398 //done
#define semaphore_wait_ex_symbol			0x340A0 //done
#define semaphore_trywait_symbol			0x33C88 //done
#define semaphore_post_ex_symbol			0x33DD4 //done

#define event_port_create_symbol			0x13728 //done
#define event_port_destroy_symbol			0x13B90 //done
#define event_port_connect_symbol			0x13C08 //done
#define event_port_disconnect_symbol			0x13B34 //done
#define event_port_send_symbol				0x13720 //done
#define event_port_send_ex_symbol			0x2D0EC //done

#define event_queue_create_symbol			0x13A30 //done
#define event_queue_destroy_symbol			0x139B8 //done
#define event_queue_receive_symbol			0x137FC //done
#define event_queue_tryreceive_symbol			0x138C8 //done

#define cellFsOpen_symbol				0x2B84B0 //done
#define cellFsClose_symbol				0x2B8318 //done
#define cellFsRead_symbol				0x2B8454 //done
#define cellFsWrite_symbol				0x2B83C0 //done
#define cellFsLseek_symbol				0x2B7C14 //done
#define cellFsStat_symbol				0x2B7CCC //done
#define cellFsUtime_symbol				0x2B963C //done ???
#define cellFsUnlink_internal_symbol			0x1A2330 //done

//RE-DONE
#define cellFsUtilMount_symbol				0x2B7988 //done
#define cellFsUtilUmount_symbol				0x2B795C //done
#define cellFsUtilNewfs_symbol				0x2B92D4 //done

//RE-DONE
#define pathdup_from_user_symbol			0x1A858C //done
#define	open_path_symbol				0x2B81E8 //done
#define open_fs_object_symbol				0x190A68 //done
#define close_fs_object_symbol				0x18F9A4 //done

//RE-DONE
#define storage_get_device_info_symbol			0x294E8C //done ???
#define storage_get_device_config_symbol		0x293518 //done
#define storage_open_symbol				0x2950B4 //done
#define storage_close_symbol				0x2938A0 //done
#define storage_read_symbol				0x29281C //FIXED!!!!!!!!!!!!!!!!!
#define storage_write_symbol				0x2926EC //done
#define storage_send_device_command_symbol		0x29233C //done
#define storage_map_io_memory_symbol			0x294D38 //done
#define storage_unmap_io_memory_symbol			0x294BF4 //done


#define new_medium_listener_object_symbol		0x9B25C //done
#define delete_medium_listener_object_symbol		0x9CA94 //done
#define set_medium_event_callbacks_symbol		0x9CDF8 //done

#define cellUsbdRegisterLdd_symbol			0x26EC2C //done
#define cellUsbdUnregisterLdd_symbol			0x26EBDC //done
#define cellUsbdScanStaticDescriptor_symbol		0x26FE2C //done ???
#define cellUsbdOpenPipe_symbol				0x26FEDC //done ???
#define cellUsbdClosePipe_symbol			0x26FE8C //done ???
#define cellUsbdControlTransfer_symbol			0x26FD90 //done
#define cellUsbdBulkTransfer_symbol			0x26FD10 //done

#define decrypt_func_symbol				0x380B4 //done
#define lv1_call_99_wrapper_symbol			0x52674 //done
#define modules_verification_symbol			0x5C1F4 //done
#define authenticate_program_segment_symbol		0x5D630 //done

#define prx_load_module_symbol				0x8B934 //done
#define prx_start_module_symbol				0x8A600 //done
#define prx_stop_module_symbol				0x8B9D8 //done
#define prx_unload_module_symbol			0x8A334 //done
#define prx_get_module_info_symbol			0x89D2C //done
#define prx_get_module_id_by_address_symbol		0x89C3C //done
#define prx_get_module_id_by_name_symbol		0x89C8C //done
#define prx_get_module_list_symbol			0x89DAC //done
#define load_module_by_fd_symbol			0x8AF64 //done
#define parse_sprx_symbol				0x88C58 //done
#define open_prx_object_symbol				0x81CE0 //done
#define close_prx_object_symbol				0x825F0 //done
#define lock_prx_mutex_symbol				0x89BE4 //done
#define unlock_prx_mutex_symbol				0x89BF0 //done

#define extend_kstack_symbol				0x72310 //done

#define get_pseudo_random_number_symbol			0x236E0C //done
#define md5_reset_symbol				0x167F24 //done
#define md5_update_symbol				0x1689C4 //done
#define md5_final_symbol				0x168B44 //done
#define ss_get_open_psid_symbol				0x2392B4 //done
#define update_mgr_read_eeprom_symbol			0x232900 //done
#define update_mgr_write_eeprom_symbol			0x232834 //done

#define ss_params_get_update_status_symbol		0x54280 //done		

#define syscall_table_symbol				0x383658 //done
#define syscall_call_offset				0x286370 //done??

#define read_bdvd0_symbol				0x1B34FC //done
#define read_bdvd1_symbol				0x1B5128 //done
#define read_bdvd2_symbol				0x1C22B0 //done

#define storage_internal_get_device_object_symbol	0x291DF4 //done

#define hid_mgr_read_usb_symbol				0x107F8C //done
#define hid_mgr_read_bt_symbol				0x101E64 //done

#define bt_set_controller_info_internal_symbol		0xF5ED0 /* just a name... */

/* Calls, jumps */
#define device_event_port_send_call			0x29F088 //done

#define ss_pid_call_1					0x222110 //done

#define process_map_caller_call				0x4D24 //done

#define read_module_header_call				0x81BD4 //done
#define read_module_body_call				0x671C //done
#define load_module_by_fd_call1				0x8B7D0 //done

#define shutdown_copy_params_call			0xAB3C //done

#define fsloop_open_call				0x2B8648 //done ???
#define fsloop_close_call				0x2B8698 //done ???
#define fsloop_read_call				0x2B86D8 //done ???

/* Patches */
#define shutdown_patch_offset				0xAB28 //done
#define module_sdk_version_patch_offset			0x275D64 //done
#define module_add_parameter_to_parse_sprxpatch_offset	0x8B040 //done		

#define user_thread_prio_patch				0x21CD8 //done
#define user_thread_prio_patch2				0x21CE4 //done

/* Rtoc entries */

#define io_rtoc_entry_1					-0xB8 //done
#define io_sub_rtoc_entry_1				-0x7EA0 //done

#define decrypt_rtoc_entry_2 				-0x65A8 //done
#define decrypter_data_entry				-0x7F10 //done

#define storage_rtoc_entry_1				0x22A0 //done

#define device_event_rtoc_entry_1			0x2628 //done

#define time_rtoc_entry_1				-0x75E0 //done
#define time_rtoc_entry_2				-0x75E8 //done

#define thread_rtoc_entry_1				-0x7660 //done

#define process_rtoc_entry_1				-0x77A0 //done

#define bt_rtoc_entry_1					-0x3548 //done

/* Permissions */
#define permissions_func_symbol				0x3560  /* before it was patch_func5+patch_func5_offset */ //done
#define permissions_exception1 				0x26BDC /* before it was patch_func6+patch6_func6_offset */ //done
#define permissions_exception2				0xC8CDC	/* before it was patch_func7+patch7_func7_offset */	//done
#define permissions_exception3				0x21DAC /* Added in v 3.0 */ //done

/* Legacy patches with no names yet */
/* Kernel offsets */
#define patch_data1_offset				0x402AC0 //done
#define patch_func2 					0x5CBAC //done
#define patch_func2_offset 				0x2C
#define patch_func8 					0x5990C //lv2open update patch //done
#define patch_func8_offset1 				0xA4 //lv2open update patch
#define patch_func8_offset2 				0x208 //lv2open update patch
#define patch_func9 					0x5D068 // must upgrade error //done
#define patch_func9_offset 				0x470
#define mem_base2					0x3D90 //done

/* vars */
// TODO: #define open_psid_buf_symbol			0x45218C
#define thread_info_symbol				0x39DAB0 //done

#elif defined(FIRMWARE_4_65) // Ported by Habib, Joonie, Haxxxen and Aldostools

#define TOC						0x34F960 //

#define create_kernel_object_symbol			0x11FB0 //
#define destroy_kernel_object_symbol			0x11914 //
#define destroy_shared_kernel_object_symbol		0x11288 //
#define open_kernel_object_symbol			0x12600
#define open_shared_kernel_object_symbol		0x12410 //
#define close_kernel_object_handle_symbol		0x11A30 //

#define alloc_symbol					0x6479C //
#define dealloc_symbol					0x64BD8 //
#define copy_to_user_symbol				0xF86C //
#define copy_from_user_symbol				0xFA88 //
#define copy_to_process_symbol				0xF924 //
#define copy_from_process_symbol			0xF734 //
#define page_allocate_symbol				0x6030C //
#define page_free_symbol				0x5FD70 //
#define page_export_to_proc_symbol			0x604A8 //
#define page_unexport_from_proc_symbol			0x5FC64 //
#define kernel_ea_to_lpar_addr_symbol			0x700C4 //
#define process_ea_to_lpar_addr_ex_symbol		0x776D8 //
#define set_pte_symbol                                  0x5E308 // 
#define map_process_memory_symbol			0x771E4 //
#define panic_symbol					0x276258 //

#define memcpy_symbol					0x7E8A4 //
#define memset_symbol					0x4D66C //
#define memcmp_symbol					0x4C97C //
#define memchr_symbol					0x4C92C //
#define printf_symbol					0x27933C //
#define printfnull_symbol				0x27DDB0 //
#define sprintf_symbol					0x4EA94 //
#define snprintf_symbol					0x4EA00 //
#define strcpy_symbol					0x4D818 //
#define strncpy_symbol					0x4D8E0 //
#define strlen_symbol					0x4D840 //
#define strcat_symbol					0x4D748 //
#define strcmp_symbol					0x4D7C4 //
#define strncmp_symbol					0x4D86C //
#define strchr_symbol					0x4D780 //
#define strrchr_symbol					0x4D950 //

#define spin_lock_irqsave_ex_symbol			0x276428 //
#define spin_unlock_irqrestore_ex_symbol		0x2763FC //

#define create_process_common_symbol			0x2741C4 //
#define create_process_base_symbol			0x273880 //
#define load_process_symbol				0x5004 //
#define process_kill_symbol				0x273FD0 //

#define ppu_thread_create_symbol			0x13EC8 //
#define ppu_thread_exit_symbol				0x13F80 //
#define ppu_thread_join_symbol				0x13FD4 //
#define ppu_thread_delay_symbol				0x287A4 //
#define create_kernel_thread_symbol			0x24B20 //
#define create_user_thread_symbol			0x2525C //
#define create_user_thread2_symbol			0x25080 //
#define start_thread_symbol				0x23D4C //
#define run_thread_symbol				0x2357C // /* temp name */
#define register_thread_symbol				0x2705DC //
#define allocate_user_stack_symbol			0x270DC4 //
#define deallocate_user_stack_symbol			0x270D2C //

#define mutex_create_symbol				0x1363C //
#define mutex_destroy_symbol				0x135D4 //
#define mutex_lock_symbol				0x135CC //
#define mutex_lock_ex_symbol				0x1DB5C //
#define mutex_trylock_symbol				0x135C8 //
#define mutex_unlock_symbol				0x135C4 //

#define cond_create_symbol				0x137A8 //
#define cond_destroy_symbol				0x13758 //
#define cond_wait_symbol				0x13750 //
#define cond_wait_ex_symbol				0x1F148 //
#define cond_signal_symbol				0x1372C //
#define cond_signal_all_symbol				0x13708

#define semaphore_initialize_symbol			0x30C54 //
#define semaphore_wait_ex_symbol			0x3095C //
#define semaphore_trywait_symbol			0x30544 //
#define semaphore_post_ex_symbol			0x30690 //

#define event_port_create_symbol			0x13078 //
#define event_port_destroy_symbol			0x134E0 //
#define event_port_connect_symbol			0x13558 //
#define event_port_disconnect_symbol			0x13484 //
#define event_port_send_symbol				0x13070 //
#define event_port_send_ex_symbol			0x2B204 //

#define event_queue_create_symbol			0x13380 //
#define event_queue_destroy_symbol			0x13308 //
#define event_queue_receive_symbol			0x1314C //
#define event_queue_tryreceive_symbol			0x13218 //

#define cellFsOpen_symbol				0x2A0590 //
#define cellFsClose_symbol				0x2A03F8 //
#define cellFsRead_symbol				0x2A0534 //
#define cellFsWrite_symbol				0x2A04A0 //
#define cellFsLseek_symbol				0x29FB28 //
#define cellFsStat_symbol				0x29FDAC //
#define cellFsUtime_symbol                              0x2A1898 // Before it was 0x2A1084 // Thanks Habib!
#define cellFsUnlink_internal_symbol			0x19C4B4 //

#define cellFsUtilMount_symbol				0x29F908 //
#define cellFsUtilUmount_symbol                         0x29F8DC
#define cellFsUtilNewfs_symbol				0x2A1330 //

#define pathdup_from_user_symbol			0x1A23A8 //
#define	open_path_symbol				0x2A02C8 // Thanks Habib!
#define open_fs_object_symbol				0x18A7D8 //
#define close_fs_object_symbol				0x189714 //

#define storage_get_device_info_symbol			0x282790 //
#define storage_get_device_config_symbol		0x281C20 //
#define storage_open_symbol				0x2821A0 //
#define storage_close_symbol				0x281F90 //
#define storage_read_symbol				0x281500 //
#define storage_write_symbol				0x2813D0 //
#define storage_send_device_command_symbol		0x28108C //
#define storage_map_io_memory_symbol			0x28264C //
#define storage_unmap_io_memory_symbol			0x282518 //
#define new_medium_listener_object_symbol		0x9743C //
#define delete_medium_listener_object_symbol		0x98C74 //
#define set_medium_event_callbacks_symbol		0x98FD8 //

#define cellUsbdRegisterLdd_symbol			0x268F0C //
#define cellUsbdUnregisterLdd_symbol			0x268EBC //
#define cellUsbdScanStaticDescriptor_symbol		0x26A10C //
#define cellUsbdOpenPipe_symbol				0x26A1BC //
#define cellUsbdClosePipe_symbol			0x26A16C //
#define cellUsbdControlTransfer_symbol			0x26A070 //
#define cellUsbdBulkTransfer_symbol			0x269FF0 //

#define decrypt_func_symbol				0x34970 //
#define lv1_call_99_wrapper_symbol			0x4EEA8 //
#define modules_verification_symbol			0x58A4C //
#define authenticate_program_segment_symbol		0x5A888 //

#define prx_load_module_symbol				0x88B7C //
#define prx_start_module_symbol				0x87848 //
#define prx_stop_module_symbol				0x88C20 //
#define prx_unload_module_symbol			0x8757C //
#define prx_get_module_info_symbol			0x87004 //
#define prx_get_module_id_by_address_symbol		0x86F14 //
#define prx_get_module_id_by_name_symbol		0x86F64 //
#define prx_get_module_list_symbol			0x87084 //
#define load_module_by_fd_symbol			0x881AC //
#define parse_sprx_symbol				0x85F30 //
#define open_prx_object_symbol				0x7F470 //
#define close_prx_object_symbol				0x7FD80 //
#define lock_prx_mutex_symbol				0x86EBC //
#define unlock_prx_mutex_symbol				0x86EC8 //

#define extend_kstack_symbol				0x7001C //

#define get_pseudo_random_number_symbol			0x230E7C //
#define md5_reset_symbol				0x161C88 //
#define md5_update_symbol				0x162728 //
#define md5_final_symbol				0x1628A8 //
#define ss_get_open_psid_symbol				0x233364 //
#define update_mgr_read_eeprom_symbol			0x22C774 //
#define update_mgr_write_eeprom_symbol			0x22C6BC //

#define ss_params_get_update_status_symbol		0x50AB4 //

#define syscall_table_symbol				0x363A18 //
#define syscall_call_offset				0x27E894 //

#define read_bdvd0_symbol				0x1AD318 //
#define read_bdvd1_symbol				0x1AEF44 //
#define read_bdvd2_symbol				0x1BC0FC //

#define storage_internal_get_device_object_symbol	0x280B44 //

#define hid_mgr_read_usb_symbol				0x1023BC //
#define hid_mgr_read_bt_symbol				0xFC294 //

#define bt_set_controller_info_internal_symbol		0xF0300 /* just a name... *///FIXED!

/* Calls, jumps */
#define device_event_port_send_call			0x28ACFC //

#define ss_pid_call_1					0x21BF98 //

#define process_map_caller_call				0x4D24 //

#define read_module_header_call				0x7F364 //
#define read_module_body_call				0x671C //
#define load_module_by_fd_call1				0x88A18 //

#define shutdown_copy_params_call			0xAACC //

#define fsloop_open_call				0x2A0728 //
#define fsloop_close_call				0x2A0778 //
#define fsloop_read_call				0x2A07B8 //

/* Patches */
#define shutdown_patch_offset				0xAAB8 //
#define module_sdk_version_patch_offset			0x26FE0C //
#define module_add_parameter_to_parse_sprxpatch_offset	0x88288 //

#define user_thread_prio_patch				0x203FC //
#define user_thread_prio_patch2				0x20408 //

/* Rtoc entries */

#define io_rtoc_entry_1					-0x1F0 //
#define io_sub_rtoc_entry_1				-0x7EA0 //

#define decrypt_rtoc_entry_2 				-0x66A0 //
#define decrypter_data_entry				-0x7F10 //

#define storage_rtoc_entry_1				0x1DD8 //

#define device_event_rtoc_entry_1			0x2048 //

#define time_rtoc_entry_1				-0x7640 //
#define time_rtoc_entry_2				-0x7648 //

#define thread_rtoc_entry_1				-0x76C0 //

#define process_rtoc_entry_1				-0x7800 //

#define bt_rtoc_entry_1					-0x3680 //

/* Permissions */
#define permissions_func_symbol				0x3560  /* before it was patch_func5+patch_func5_offset *///
#define permissions_exception1 				0x25100 /* before it was patch_func6+patch6_func6_offset *///
#define permissions_exception2				0xC3210	/* before it was patch_func7+patch7_func7_offset */	//
#define permissions_exception3				0x204D0 /* Added in v 3.0 *///

/* Legacy patches with no names yet */
/* Kernel offsets */
#define patch_data1_offset				0x3E2BC0 //
#define patch_func2 					0x59CFC //
#define patch_func2_offset 				0x2C //
#define patch_func8 					0x5640C //lv2open update patch // Thanks Habib!
#define patch_func8_offset1 				0xA4 //lv2open update patch //
#define patch_func8_offset2 				0x208 //lv2open update patch //
#define patch_func9 					0x5A1B8 // must upgrade error //
#define patch_func9_offset 				0x4B8 // Thanks Habib!
#define mem_base2					0x3D90 //

/* vars */
// TODO: #define open_psid_buf_symbol			0x45218C
#define thread_info_symbol				0x37DBB0 //


#endif /* FIRMWARE */

#endif /* __FIRMWARE_SYMBOLS_H_S__ */
