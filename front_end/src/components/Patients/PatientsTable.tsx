import { useState } from "react";
import {
  createStyles,
  Table,
  ScrollArea,
  UnstyledButton,
  Group,
  Text,
  Center,
  TextInput,
  rem,
} from "@mantine/core";
import { keys } from "@mantine/utils";
import {
  IconSelector,
  IconChevronDown,
  IconChevronUp,
  IconSearch,
} from "@tabler/icons-react";
import { Patient } from "../../models/types";

const useStyles = createStyles((theme) => ({
  th: {
    padding: "0 !important",
  },

  control: {
    width: "100%",
    padding: `${theme.spacing.xs} ${theme.spacing.md}`,

    "&:hover": {
      backgroundColor:
        theme.colorScheme === "dark"
          ? theme.colors.dark[6]
          : theme.colors.gray[0],
    },
  },

  icon: {
    width: rem(21),
    height: rem(21),
    borderRadius: rem(21),
  },
}));
// interface RowData {
//   name: string;
//   email: string;
//   company: string;
// }

interface TableSortProps {
  data: Patient[];
}

interface ThProps {
  children: React.ReactNode;
  reversed: boolean;
  sorted: boolean;
  onSort(): void;
}

function Th({ children, reversed, sorted, onSort }: ThProps) {
  const { classes } = useStyles();
  const Icon = sorted
    ? reversed
      ? IconChevronUp
      : IconChevronDown
    : IconSelector;
  return (
    <th className={classes.th}>
      <UnstyledButton onClick={onSort} className={classes.control}>
        <Group position="apart">
          <Text fw={500} fz="sm">
            {children}
          </Text>
          <Center className={classes.icon}>
            <Icon size="0.9rem" stroke={1.5} />
          </Center>
        </Group>
      </UnstyledButton>
    </th>
  );
}

const filterData = (data: Patient[], query: string) => {
  const keysToFilter = keys(data[0]);
  return data

    .filter((item) =>
      keysToFilter.some((key) =>
        String(item[key])
          .toLowerCase()
          .trim()
          .includes(query.toLowerCase().trim())
      )
    )
    .sort((a, b) => a.FirstName.localeCompare(b.FirstName))
    .reverse();
};

const sortData = (
  data: Patient[],
  {
    sortBy,
    reversed,
    search,
  }: { sortBy: keyof Patient | null; reversed: boolean; search: string }
) => {
  const sortedData = sortBy
    ? [...data].sort((a, b) => {
        if (a[sortBy] < b[sortBy]) {
          return reversed ? 1 : -1;
        }
        if (a[sortBy] > b[sortBy]) {
          return reversed ? -1 : 1;
        }
        return 0;
      })
    : data;

  return search ? filterData(sortedData, search) : sortedData;
};

export function PatientsTable({ data }: TableSortProps) {
  const [search, setSearch] = useState("");
  const [sortedData, setSortedData] = useState<Patient[]>(data);
  const [sortBy, setSortBy] = useState<keyof Patient | null>(null);
  const [reverseSortDirection, setReverseSortDirection] = useState(false);

  const setSorting = (field: keyof Patient) => {
    const reversed = field === sortBy ? !reverseSortDirection : false;
    setReverseSortDirection(reversed);
    setSortBy(field);
    setSortedData(sortData(data, { sortBy: field, reversed, search }));
  };

  const handleSearchChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { value } = event.currentTarget;
    setSearch(value);
    setSortedData(
      sortData(data, { sortBy, reversed: reverseSortDirection, search: value })
    );
  };

  const rows = sortedData.map((patient) => (
    <tr key={patient.Id}>
      <td>{patient.FirstName}</td>
      <td>{patient.LastName}</td>
      <td>{patient.Age}</td>
      <td>{patient.EntryDate}</td>
      <td>{patient.ExitDate}</td>
      <td>{patient.AddressName}</td>
    </tr>
  ));

  return (
    <ScrollArea>
      <TextInput
        placeholder="Search by any field"
        mb="md"
        icon={<IconSearch size="0.9rem" stroke={1.5} />}
        value={search}
        onChange={handleSearchChange}
      />
      <Table
        horizontalSpacing="md"
        verticalSpacing="xs"
        miw={700}
        sx={{ tableLayout: "fixed" }}
      >
        <thead>
          <tr>
            <Th
              reversed={reverseSortDirection}
              sorted={sortBy === "FirstName"}
              onSort={() => setSorting("FirstName")}
            >
              First Name
            </Th>
            <Th
              sorted={sortBy === "LastName"}
              reversed={reverseSortDirection}
              onSort={() => setSorting("LastName")}
            >
              Last Name
            </Th>
            <Th
              sorted={sortBy === "Age"}
              reversed={reverseSortDirection}
              onSort={() => setSorting("Age")}
            >
              Age
            </Th>
            <Th
              sorted={sortBy === "EntryDate"}
              reversed={reverseSortDirection}
              onSort={() => setSorting("EntryDate")}
            >
              Entry Date
            </Th>
            <Th
              sorted={sortBy === "ExitDate"}
              reversed={reverseSortDirection}
              onSort={() => setSorting("ExitDate")}
            >
              Exit Date
            </Th>
            <Th
              reversed={reverseSortDirection}
              sorted={sortBy === "AddressName"}
              onSort={() => setSorting("AddressName")}
            >
              Address
            </Th>
          </tr>
        </thead>
        <tbody>
          {rows.length > 0 ? (
            rows
          ) : (
            <tr>
              <td colSpan={Object.keys(data[0]).length}>
                <Text weight={500} align="center">
                  Nothing found
                </Text>
              </td>
            </tr>
          )}
        </tbody>
      </Table>
    </ScrollArea>
  );
}
