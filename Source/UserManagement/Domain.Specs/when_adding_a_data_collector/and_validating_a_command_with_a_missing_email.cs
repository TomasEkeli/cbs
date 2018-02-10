/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017 International Federation of Red Cross. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Domain;
using System;
using Machine.Specifications;
using doLittle.Validation;
using System.Linq;
using System.Collections.Generic;
using Concepts;

namespace Domain.Specs.when_adding_a_data_collector
{
    [Subject(typeof(AddDataCollectorValidator))]
    public class and_validating_a_command_with_a_missing_email
    {
        static AddDataCollector cmd;
        static AddDataCollectorValidator validator;
        static IEnumerable<ValidationResult> validation_results;

        Establish context = () => 
        {
            validator = new AddDataCollectorValidator();

            cmd = new AddDataCollector
            {
                Id = Guid.NewGuid(),
                FirstName = "Data",
                LastName = "Collector",
                Age = 25,
                Sex = Sex.Male,
                NationalSociety = Guid.NewGuid(),
                PreferredLanguage = Language.English,
                GpsLocation = new Location(123,123),
                MobilePhoneNumber = "123456789",
                Email = string.Empty
            };
        };

        Because of = () => { validation_results = validator.ValidateFor(cmd); };

        It should_be_invalid = () => validation_results.ShouldBeInvalid();
        It should_have_two_validation_errors = () => validation_results.ShouldHaveInvalidCountOf(2);
        It should_identify_the_email_as_the_problem = () => validation_results.ShouldHaveInvalidProperty(nameof(cmd.Email));
    }
}