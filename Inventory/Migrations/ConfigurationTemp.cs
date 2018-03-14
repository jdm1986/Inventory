namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Inventory.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Inventory.InventoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Inventory.InventoryContext context)
        {
            context.MachineTypes.AddOrUpdate(
                t => t.TypeName,
                new MachineType { TypeId = 1, TypeName = "Excavator" },
                new MachineType { TypeId = 2, TypeName = "Dozer" },
                new MachineType { TypeId = 3, TypeName = "Tractor" }
            );

            context.SaveChanges();

            context.Machines.AddOrUpdate(
                m => m.MachineId,
                new Machine
                {
                    MachineId = 1,
                    MachineNum = 578,
                    MachineMake = "Deere",
                    MachineModel = "9520",
                    Hours = 8510,
                    Status = true,
                    TypeId = 3,
                    Photo = "https://lh3.googleusercontent.com/xWeqYYron9HBJYUULnViQapIkxKKwv4zYQHI0O2TegUio8omn9gPrRs04JjM8_CQoG6ELblz7Qb84dRc6vvYrCX6zHGETdcCrsXpjifaaP8GkLJBTR-bD8ViDHbliCXpWX7C3s4YdbOzshg8Es0Zr2mxZycdnARnHR49FIngtbI0cngygx2WsLcJZ6LsGnnQwNN9rztuJMkTwxGx4V_3p2aOSDkyI9nej1lvzEx6g8UCA2khxJkum_DUsR5xysCN3I5tX6bZ3SGW1XFuLBr3s6i6mq7wUg5ZY4aQumBNlcVwVixBAAjCngSE2WuWOFB4ruzJjSqaaWqepH7jqfr8Eb6s7vqMyTtXW6up2H-CWmnfx8iRVzUDJqP8dzBRi8ipN9SkcT8dck3UQrIdeqwDgmFZMKEmswsNt6JO5N126rYDDJtnbjXjKlZhHQ1kMoKLLE9yYjBOJDxk4Jurd-gD1APxZpXihZYmzMTBdA1S_NAnPFuogErvFAlaHCvRS_3ZKEkYuxUQ8ZV-20lEXprq7yjfASVAHeFbj-RHaQFXQ4q0xbSLEIP19gybVu_kGUVlEJrNXovety_aLNgOll66_f4o6SFBhsXEGe60qNdIWVxcNpCPnx6sHKhG-nn_lkATAKmeLt-VlEnG3V0nyDqCESUFXhchaC0o=w901-h675-no"
                },
                new Machine
                {
                    MachineId = 2,
                    MachineNum = 647,
                    MachineMake = "CAT",
                    MachineModel = "D8T",
                    Hours = 6500,
                    Status = false,
                    TypeId = 2,
                    Photo = "https://lh3.googleusercontent.com/K7A1o9Hgqa00VxoGN2KMx6WPEQm1KFOgnAqbGnl7oqTDZeexOAI81HcFBMQKiXns-xrY9qNfKscRyuBkMHLxLbOVCfey2hs-F4a2egcD_UBN8AeOCRnoeWdNMz-Q0CnRLnXgiVIVFLqdEkQoVTVlR13DMidz_P4pO2Pej8aJKD1frAWgHE6CaBYhSp1QTMCtO0qz-ZPRIb20OQ18R5SelxDp2J_dLrGtPcudOuCEcPRfO6DdB3txliqppNQoP0cY0QkkQUsZb1kxgV4qXATC1QjMlVr46TRoIOT3OF1BhXRh42uzmXpP1C1W8fZNbnq9RmzcwGtAHLenDPPsNlLsci5lgB9G4nnyT1bMm0rZv_3-Ep8av5AXjs21xOHBDVHYF90nUCGQJg9OwzMUY9dT3DeNvo2kXNsrI6o0IVJifTgQwhdbsoDZfB4_ybvW4__XcJsdafyXXhObx_odzQIO1fKOcXHJJBUOR_8D3d8NPFpZob1y2Kq3Arkto-m1cSQWdTLeQb1ROIYA1ny7xs23Kc5wV9v4hggHHOaolvxJmyC7_wOSA47mt9TNcOZABYQhDEAIHKhY-HSVZxoR4rcxhi6sWsWLyD31z0jLsGIHOaiMmCGEgVlr-MZsRLhG8qG7pTrnaOitMGpwWgwjBZ9NDPiHYT2a8qpg=w1239-h675-no"
                },
                new Machine
                {
                    MachineId = 3,
                    MachineNum = 658,
                    MachineMake = "Komatsu",
                    MachineModel = "PC450",
                    Hours = 7003,
                    Status = true,
                    TypeId = 1,
                    Photo = "https://lh3.googleusercontent.com/3bfwyuLk-O_8Wk2YaWuJlz6DMp50IavdNhpd_9HoORynvcEGMnpH6tJW3iVnxdRDYotakfeHlToOjCm4Q4xztgk9pvTgNxGiUFCkUuooK3514akLK_jK9RpXoxzHxGkwRg-izNvTOYXEnjxLpFzQAc3nPKQQPEAZ-6PUckp3jyqhB5ywOdMN8L76wU2iq5LEVsf-cukOG8K0xLpDjZvIqUS1OlQwPHx4muomfqviotY_cKR39MEzD30ohvIIAvXRKH7PDlGCZyOJiOg9CAb-O8HUFmO3NhtuaNu87jNeVWd7RajU1ZKK3PrV9Ze3rspQ88N7gqek9K0mzB0m2g32lwww4MDpjQ8jeQRuEup7Xdt94KFjQM-cC8noF2o6UPIPkHZKiMG06Dabxk3NCPxPBChn5rQGTGwA3novkVGTvfesqPIMxXsbYoQbUfdakds4LEbq6Cjc7VZZTP-PPFPNxNMWKxkmaUwDatSelplDEow20lomO-6ODQMFt59ZIXVX6wS8RjE-ybrhKpLt87SjhruG1QfIuuqVReU-oAXpoRcxAnB0_t_nEshINzCKH5dsiOO8fseZo4i7uL_dL6TomukkAUCTEp9eBwMxPv8_z6ZWZbLg48B4N807KRPvaFmoZTLl4Uvq-Ep3qeJLzqxZvyg0ktTmiDTC=w900-h675-no"
                },
                new Machine
                {
                    MachineId = 4,
                    MachineNum = 768,
                    MachineMake = "Deere",
                    MachineModel = "250G",
                    Hours = 4379,
                    Status = true,
                    TypeId = 1,
                    Photo = "https://lh3.googleusercontent.com/XKb9cd51GjK9Z7ZzwvzDkOtz0BC3YGr4wTG4suJha0j7gVR-UdD-OGTfmL777ijL4H5GBVCq8Bf6s9gJCWm8SKjz3fOvGLQiyEpl_RyuZjKSLOd9VBQeUyaX01BtPvoLDdMycRjAR8VxNaNq0nvO_UkIiI5Awb6lxiv08uZe563FckNGAPDFpzoAFFx4PeBNtxUuoFru4Bwg2JGUqIEhLmXypRhf1z_MTFlwVxOmQHspVfoN9UNtbqqHvHs07vKqfYI4gD8F322nc484_a4c8oGK7EE8JIZ9ntdU_h-auEcMJ3ABcCsXxUDam0Y3RJJpPT7qrMGuRFuu47zY5hkPSc6mrUhK-aWMfXvZ4i4_McsQvzJGT605ILIHKfZflbaTN0Bt8LCqdWZNcvzpUEeX5CallJoG6vq-M6g2KPKl9zhSEOQvazz_OrDgnbuGIj8W-NDPuT7wVUoK1xiFoCe1VHhC68N6Rm3f3m4H9zF2F91WOgB69WPYlRhsx7uk6x-RtBYqOTjXivBwvdS7UnOkWE5Fn4PTQ4MvzJTiRpiFXnWD0p72pUUjEvXa7Gqcy1pUpWMrF3YGTkCie-BsL97t1ZQXNxrj2jmRISV_tluX2KJ2xCYzHq24jdvLmUxncGVGN47gG156_ZZWQRFjZW93jW-jVc6uDpQn=w901-h675-no"
                },
                new Machine
                {
                    MachineId = 5,
                    MachineNum = 769,
                    MachineMake = "Deere",
                    MachineModel = "750J LGP",
                    Hours = 3189,
                    Status = false,
                    TypeId = 2,
                    Photo = ""
                },
                new Machine
                {
                    MachineId = 6,
                    MachineNum = 777,
                    MachineMake = "Deere",
                    MachineModel = "250G",
                    Hours = 3534,
                    Status = true,
                    TypeId = 1,
                    Photo = ""
                },
                new Machine
                {
                    MachineId = 7,
                    MachineNum = 790,
                    MachineMake = "Deere",
                    MachineModel = "750J LGP",
                    Hours = 3011,
                    Status = true,
                    TypeId = 2,
                    Photo = "https://lh3.googleusercontent.com/WYgoeHFK0hlLYSlhcoU9NYw3RqQ9KQgXLBur28ZiNDnqEeE9K43oEb5GlgUC1WnEmMO-7D1vWd0Ou3ufPLtdUD1vOdAB7e-cCmD-IOvlrt85TJ8DW_S4f6TcnZbSo9o6dTK0OMAJg--YdeoAqsxzXC1N7XD4WU9LsMI3eRa1pKfbHeZoT37b7ePk8yFR893wADzUPu-1KIqtdCKLInwbfoyPGDcD7nGBh6-HRcRg8vj9XTwVZVL0-aacCnpXvHLaAvlMh2VpSEHtsGIS-KfiCnz4ZboqGqCC4eNGxMHxwZ63fU7XBJ2iG83x0foro-Tdg2GUw_9BhOrBS8_k85NdMd0Izffcap-zYtVXnFTChr8nS7xzzzmBHRcPhJhAjNITdfI-ki-i3eO9KrfHwHni3gsh1-LbBHGYx2zKqCskfZHKzDnRAIKM-eWohnXK-tZV28qtj66Flih13dR6dprp9U8vDzuMtC7Dl_1EmtxJLKosaGqXM-XgfKrW-9iJ02Fm1hHQoZqS2lUALwu2vIdZ8J7KhZ9lSi9F1yaW_vGOJ0E7ECuQS7RT8cS8kb6gXy6B43fYIoxIq7dZ4wRvUD7SY51wF6fLQgNYjPrRU5z7ms354tcWqSjuHF-ObYlFJXdhOuDgV3X6VfWSReerk_SdJw80aiV8-Qqe=w935-h675-no"
                },
                new Machine
                {
                    MachineId = 8,
                    MachineNum = 792,
                    MachineMake = "Deere",
                    MachineModel = "850K",
                    Hours = 2730,
                    Status = true,
                    TypeId = 2,
                    Photo = ""
                },
                new Machine
                {
                    MachineId = 9,
                    MachineNum = 905,
                    MachineMake = "CAT",
                    MachineModel = "D5K LGP",
                    Hours = 2275,
                    Status = true,
                    TypeId = 2,
                    Photo = ""
                },
                new Machine
                {
                    MachineId = 10,
                    MachineNum = 910,
                    MachineMake = "Deere",
                    MachineModel = "450J LT",
                    Hours = 692,
                    Status = true,
                    TypeId = 2,
                    Photo = ""
                },
                new Machine
                {
                    MachineId = 11,
                    MachineNum = 918,
                    MachineMake = "Deere",
                    MachineModel = "350G",
                    Hours = 576,
                    Status = false,
                    TypeId = 1,
                    Photo = ""
                }


                );
            context.SaveChanges();

            context.AttachmentTypes.AddOrUpdate(
            s => s.TypeName,
            new AttachmentType { TypeId = 4, TypeName = "Bucket" },
            new AttachmentType { TypeId = 5, TypeName = "Hammer" },
            new AttachmentType { TypeId = 6, TypeName = "Thumb" }
        );

            context.SaveChanges();

            context.Attachments.AddOrUpdate(
                a => a.AttachmentId,
                new Attachment { AttachmentId = 1, AttachmentNum = 193, AttachmentMake = "CAT", AttachmentModel = "24 in bucket", Status = false, TypeId = 4 },
                new Attachment { AttachmentId = 2, AttachmentNum = 143, AttachmentMake = "AIM", AttachmentModel = "36 in bucket", Status = false, TypeId = 4 },
                new Attachment { AttachmentId = 3, AttachmentNum = 133, AttachmentMake = "Allied", AttachmentModel = "AR160", Status = false, TypeId = 5 },
                new Attachment { AttachmentId = 4, AttachmentNum = 133, AttachmentMake = "Allied", AttachmentModel = "AR130", Status = false, TypeId = 5 },
                new Attachment { AttachmentId = 5, AttachmentNum = 543, AttachmentMake = "Allied", AttachmentModel = "BR777", Status = false, TypeId = 5 },
                new Attachment { AttachmentId = 6, AttachmentNum = 467, AttachmentMake = "Allied", AttachmentModel = "BR999", Status = false, TypeId = 5 },
                new Attachment { AttachmentId = 7, AttachmentNum = 322, AttachmentMake = "Allied", AttachmentModel = "AR70", Status = false, TypeId = 5 },
                new Attachment { AttachmentId = 8, AttachmentNum = 654, AttachmentMake = "Allied", AttachmentModel = "AR70", Status = false, TypeId = 5 }



                );
 

              
            context.SaveChanges();
        }
    }
}
