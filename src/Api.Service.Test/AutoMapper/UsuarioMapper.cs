using System;
using System.Collections.Generic;
using System.Linq;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using Xunit;

namespace Api.Service.Test.AutoMapper
{
    public class UsuarioMapper : BaseTesteService
    {
        [Fact(DisplayName = "É possível Mapear os Modelos")]
        public void E_Possivel_Mapear_os_Modelos()
        {
            var userModel = new UserModel
            {
                Id = Guid.NewGuid(),
                Name = Faker.Name.FullName(),
                Email = Faker.Internet.Email(),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow

            };

            var listaEntity = new List<UserEntity>();
            for (int i = 0; i < 5; i++)
            {
                var item = new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email(),
                    CreateAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };
                listaEntity.Add(item);
            }

            //UserModel para UserEntity
            var userEntity = Mapper.Map<UserEntity>(userModel);
            Assert.Equal(userEntity.Id, userModel.Id);
            Assert.Equal(userEntity.Name, userModel.Name);
            Assert.Equal(userEntity.Email, userModel.Email);
            Assert.Equal(userEntity.CreateAt, userModel.CreateAt);
            Assert.Equal(userEntity.UpdateAt, userModel.UpdateAt);

            //UserEntity para UserDto
            var userDto = Mapper.Map<UserDto>(userEntity);
            Assert.Equal(userDto.Id, userEntity.Id);
            Assert.Equal(userDto.Name, userEntity.Name);
            Assert.Equal(userDto.Email, userEntity.Email);
            Assert.Equal(userDto.CreateAt, userEntity.CreateAt);

            var listaDto = Mapper.Map<List<UserDto>>(listaEntity);
            Assert.True(listaDto.Count() == listaEntity.Count());
            for (int i = 0; i < listaDto.Count(); i++)
            {
                Assert.Equal(listaDto[i].Id, listaEntity[i].Id);
                Assert.Equal(listaDto[i].Name, listaEntity[i].Name);
                Assert.Equal(listaDto[i].Email, listaEntity[i].Email);
                Assert.Equal(listaDto[i].CreateAt, listaEntity[i].CreateAt);

            }

            var userDtoCreateResult = Mapper.Map<UserDtoCreateResult>(userEntity);
            Assert.Equal(userDtoCreateResult.Id, userEntity.Id);
            Assert.Equal(userDtoCreateResult.Name, userEntity.Name);
            Assert.Equal(userDtoCreateResult.Email, userEntity.Email);
            Assert.Equal(userDtoCreateResult.CreateAt, userEntity.CreateAt);

            var userDtoUpdateResult = Mapper.Map<UserDtoUpdateResult>(userEntity);
            Assert.Equal(userDtoUpdateResult.Id, userEntity.Id);
            Assert.Equal(userDtoUpdateResult.Name, userEntity.Name);
            Assert.Equal(userDtoUpdateResult.Email, userEntity.Email);
            Assert.Equal(userDtoUpdateResult.UpdateAt, userEntity.UpdateAt);

            //UserDto para UserModel
            var userModelToDto = Mapper.Map<UserModel>(userDto);
            Assert.Equal(userModelToDto.Id, userDto.Id);
            Assert.Equal(userModelToDto.Name, userDto.Name);
            Assert.Equal(userModelToDto.Email, userDto.Email);
            Assert.Equal(userModelToDto.CreateAt, userDto.CreateAt);

            var userDtoCreate = Mapper.Map<UserDtoCreate>(userModelToDto);
            Assert.Equal(userDtoCreate.Name, userDto.Name);
            Assert.Equal(userDtoCreate.Email, userDto.Email);

            var userDtoUpdate = Mapper.Map<UserDtoUpdate>(userModelToDto);
            Assert.Equal(userDtoUpdate.Id, userDto.Id);
            Assert.Equal(userDtoUpdate.Name, userDto.Name);
            Assert.Equal(userDtoUpdate.Email, userDto.Email);


        }

    }
}
