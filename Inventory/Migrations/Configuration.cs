namespace Inventory.Migrations
{
    using Inventory.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
                    Notes = "w/ ripper",
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
                    Notes = "Trimble ready",
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
                    Notes = "plumbed for hammer",
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
                    Photo = "https://lh3.googleusercontent.com/utoian58jD7U1CVSU2oPSYkVhF0tnTGluFUDm8RDqR07Tt-vjTVMoE5nCOXwn7T74vkfx1v5ZR27-9zED2htC3vwUhNhfxubIQuiZxkNlNzesVm7XdvhkuxO3CgSmgDRObLX--7K1XJaR1wNGJ0lpON-1NYiHQuUMBsaJ6q5ijw3_ZTbMYy-wHHwxm_QTsAVZr4-QWu8gBaA9hpTuTizUzxhPeKH0bpABo9r14dk98Cazo1D8dFddlHXS7XnTUK310UFFylRHLJWqCYodKoHbQ92ohQCIykzFIX8lLB2XXvbGlgNmr2Ey7mEBQ4eEWHHPHoCj11GEPYkP2jKKXn-_cu9Fj4kvjOxxuVZxX8WAV76wUKVGvD87Yv75V1wMuVqbdKTOc1dliTJxSPPb1sasLuT2O9o65G06G7yEMm9gYsSGSOcQxgdvSwZukZIu2lWCWG8Qi8awbS5Iab-SrDhmmRlJx1vjdLgob5kkP12FfGazhKyZyLAqWZN6OW7IdYzYQp5-vNV0xqhSonLz_LmdzU7ICJDDGyPwUoIHi6Cb_Y3rl5GYWhXcaKJU-N85wUPm4DxzJhbBkrtK4Zx8Gop8MwiFky7yow9Tp4FXr-lfJba8Lx_an0qS-7zKcuWE5Sp5pSDbCbJmnWQ7XZ7GMblxtPKJ0HhWwdL=w504-h378-no"
                },
                new Machine
                {
                    MachineId = 6,
                    MachineNum = 804,
                    MachineMake = "Deere",
                    MachineModel = "250G",
                    Hours = 3534,
                    Status = true,
                    TypeId = 1,
                    Notes = "aux hydraulics",
                    Photo = "https://lh3.googleusercontent.com/4OjtAuMk6F_Q9uWvsRiIC6EAuaxg978EZyjl9PUtakxlloaTny4QMBfPbreWoCbI8YQfMSfzPHWso9YrB95nQTjcHtbwLab9CIetmk4vsutzzRcGEWGLAtzrpskjkNRgYWtFlCTbdAz9YsqN_QRRk3mK9kpb7Youz42g6rfxB00dgF1FTCcjUw99ZVUMEzx1zccCL1HbeabiKJ5zknghEwvQ-5C3wE0d9wqBp6ceO9iTqjsZ-0zrCU7IvndMlaGlEdl9n8l5o07gd9OF_jp2xTShH9bGvkZtYC4_fPON34HcJxr7FlVK-Cs58VOFl6ucEFwirEN0M6BTLo_ngMe1VK8Oe_GCTcqtdsrj_zm4fKLQKa67ds0hz-sHbXjjsdmwPZHBWAUtmHjcuke3SBFIOOg49rhiDp9sT1Dv0t5FTZe57OBykBj9aUTPO68BHjQA1WtYvEX9GFuYG39ZSp0-6mWPNi7S3i3pDLtykvK1T_T2IiCma9NRlJraVD0BFPolNisTdwLydLBF6oSvSOcb2G6yUzRvfO9R45Sbs5epWCVZyOU8R-eWkQad_XJvxFhEppMBLKRK_3k6gX60goS6q56wNzL4iUNdZ2yIive31COi56xbtNs667YXrUrSjmtpCSZL4N58Vq4_XqTlbddJzVM2WzNRo8aW=w1316-h987-no"
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
                    TypeId = 2

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
                    Photo = "https://lh3.googleusercontent.com/ATK6AvKTQUK5rR69Cw7MXpBdLA-DpocBMrBcvucFTJCJMYkMoSTcqpGfRgT7gkB55VZikoIgTLLUmZ9zV2Hpzf6e6EfM0TqR3D-u7W81Gb_-4KjLs7IDm1qyEcRWpEoh0Eym0WsaksbYNSZRFAfdDaiEbGIktVK0txAqSx59hypwRjhPslYgcU1s6gYwkiOBNJoDanwwMbzCOfDuLRVwdYv8NolxxMWjgbLEEkoM-mofRMhxsfvvLm26QePJiauDt2Hnr05NlgUmF4epnl7VQTiLaOl1NJnImnsehWOJdmuN2n00qUQ_BV-5ELEIltVXiBaBxkYAAM1v6XZWqueq4XqZ0Z5YSoEfB0rkk41Sy07lT5TnlU-v1SVSf8fqnNfYk9Y8wbRTUkhMzJ0DY8Iam2q8ayx7BEQfUzRdlfWxHDCOnnHz0Bzn4DCuYdsuNmycs2DNE2bPcKqHALHx-48avKQnfZEgxkhNR7iwG_X8rxxACDlnvpXK_oFA6IfUSEqjBmjom3OkuFsf1QuqtEyUR1EeCFliG5zX19dmNdZINr77_ZZvZA4qAg0eF0T-yEgM64dJM5xjB-qWC5MlX-rVR62cw-eUdgEGDbQTn1ItcXZ4AY-ZqTE_6DYIFKdxgylJ3VAiJLO_6hRbVug3xJpq0rB_CScYQVJP=w1316-h987-no"
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
                    Photo = "https://lh3.googleusercontent.com/5T0_ThDF1nkKcT1vQzW_aFOj_KmI0QFygNEriRRIbG7jfPLHuHunsh4C3cmkRKblz7bajlIaTLLkUhlWA83iaitj2BofMnp5HZ10flEZE_CiYW7Z86HRHWj2fDlAe7aeLT_7r0XAp2DDQn_NhvwweWCu3sWuDvii_DDsAEfxmS0CVS4pY1pj7aHo2eB0d9YIxEUdMXu8Bbdok0Yr0hxXkyopNKzyIx2Mihwij3JpuqZl1HvTymoCu_ZVCaZM_9UkKthoqbnJjRzHxMa0NbrQNRiOTw0TQ9Ity-DnnTsP8bAD3W1UBdtP8pWdgyTBqWBLvhmeJNd5xIWYnW8qhZ6ml8fGDIKn_IFGKpJA13TpBJaR4KlkaG3HEDy2sD0JC7MOT6SkvzLcKce12ZCkqe1X9agFrrUGxotXAsyJQUJW0cyhoxsfd9MLqNsVJhMTprGz1OizoHS5Xt8oiyJRPP5hNHTK_jzHdYgvCjENSwx2l_dDhBYcJUEJtskF7WfS-22TB2wLB5iJkqhYzOqM97lz-YJh24VGAl_JkHCmjQfhL6X8wk7rnSVgUjcSg4o8Yn81BeiqeGddR9t4Cq6UQhQA0trUCawzufp_UBWjTFoN6wC1POreM7beMmTmS_2d-dYTrSenDIxv7KEMphO8mHiIjvuMBDJ-We9h=w1316-h987-no"
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
                    Notes = "plumbed for hammer",
                    Photo = "https://lh3.googleusercontent.com/1hwCr8I-uY5DyLYfOSvdYl1SKGrrN-xg7Yfzqm1SX4hqz9RiALd08tzjpQ-jdFrt0SDuWPRC1B_utf8HYta1sLKmLUPG2q-jGccaafA9Ai_8ur935H1jHss3w_59dtbzWJ24lE-y9TpUkTNUYV5je2PL7Q5r_QpgzZ0HbTiWIp1TNhtXoymlzQPTZm6sVSG78T8lcg9SZdPYAa-dCBT1ItklcgjEEEmx5Z49JNdvlyOfr86RL8igDKWIW0TlDtRAMNB_-xKz7UaDW69Fay_jzUsIUl8DRfPrnPo_n0Kk5abtlv1OyQ0bD4x6JatA1O2MTyIOmelFcq8UuvfiIQZHjJ00YnUvH-UYAEiyAQg8RogG7GQRrvUPiK6j3u2mzYWEql3kNQBCVRYo4BC9LK6IitMpcMxv4zmFKmKghZitSKJtv-CRiRxA6b-viph14iXp4AVcxqyrbnPYxg_bZeYPeC--mY7dtXwW8i9h1mGeNy1pnk-rJ8Dot7eaXNjiXR1lr_2QFBBpiW2B91grnxDufoqZfB_I3P6w39rCs6jTuKWTkxPGDT1cAhARJ0izhUIMIAd2WPa0zLBg59uqvTO7nv-6BA8nZMqWAJpB8MGIR4W7oY_tbTCFZ_sdUy3CVVWLXzFfH2w-iKMwigkr4S4ROdfEFhh0R-tn=w1389-h987-no"
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
                new Attachment { AttachmentId = 1, AttachmentNum = 193, AttachmentMake = "CAT", AttachmentModel = "24 in bucket", Status = true, TypeId = 4, Notes = "fits 315CL" },
                new Attachment { AttachmentId = 2, AttachmentNum = 143, AttachmentMake = "AIM", AttachmentModel = "36 in bucket", Status = true, TypeId = 4 },
                new Attachment { AttachmentId = 3, AttachmentNum = 133, AttachmentMake = "Allied", AttachmentModel = "AR160", Status = true, TypeId = 5, Notes = "fits 350G" },
                new Attachment { AttachmentId = 4, AttachmentNum = 134, AttachmentMake = "Allied", AttachmentModel = "AR130", Status = true, TypeId = 5 },
                new Attachment { AttachmentId = 5, AttachmentNum = 543, AttachmentMake = "Allied", AttachmentModel = "BR777", Status = true, TypeId = 5 },
                new Attachment { AttachmentId = 6, AttachmentNum = 467, AttachmentMake = "Allied", AttachmentModel = "BR999", Status = true, TypeId = 5 },
                new Attachment { AttachmentId = 7, AttachmentNum = 322, AttachmentMake = "Allied", AttachmentModel = "AR70", Status = false, TypeId = 5, Notes = "fits 18,000 lb exc" },
                new Attachment { AttachmentId = 8, AttachmentNum = 654, AttachmentMake = "Allied", AttachmentModel = "AR70", Status = false, TypeId = 5 }



                );



            context.SaveChanges();
        }
    }
}