//Luis Reyes
//ITSE 1430
//Lab 5: Character SqlSever
using System;
using System.Collections.Generic;

using CharacterCreator;

namespace SqlServerCharacterRoster
{
    public class SqlServerCharacterRoster : CharacterCreator.CharacterRoster

    {
        public SqlServerCharacterRoster(string connectionString)
        {
            _connectionString=connectionString;
        }
        protected override Character AddCore ( Character character )
        {
            throw new NotImplementedException();
        }

        protected override void DeleteCore ( int id )
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Character> GetAllCore ()
        {
            throw new NotImplementedException();
        }

        protected override Character GetCore ( int id )
        {
            throw new NotImplementedException();
        }

        protected override void UpdateCore ( int id, Character character )
        {
            throw new NotImplementedException();
        }
        private readonly string _connectionString;
    }
}
